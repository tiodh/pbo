using System;
namespace TM05.Models
{
	public class Rekening
	{
		private string nomor_rekening;
		private Nasabah nasabah;
		private Kredit kredit;
		private Debit debit;
		private int saldo;

		public Rekening(Nasabah _nasabah)
		{
			this.nomor_rekening = generate_rekening();
			this.nasabah = _nasabah;
			this.kredit = new Kredit();
            this.debit = new Debit();
        }

		public void print()
		{
			Console.WriteLine("Nomor Rekening: "+this.nomor_rekening);
			this.nasabah.print();
		}

		private void print_saldo()
		{
			this.get_saldo();
			Console.WriteLine("Saldo: "+this.saldo);
		}

		private string generate_rekening()
		{
			string tmp = "";
			Random r = new Random();

			for(int i=0;i<10;i++)
			{
                tmp += r.Next(0, 9).ToString();
            }
			return tmp;
		}

        public void setor()
        {
			Console.WriteLine("Setor: ");
			int nominal = int.Parse(Console.ReadLine());
			this.kredit.add(nominal);
			this.print_saldo();
        }

        public void tarik()
        {
            Console.WriteLine("Tarik: ");
            int nominal = int.Parse(Console.ReadLine());
			int tmp = this.saldo - nominal;
			if(tmp>=0)
			{
                this.debit.add(nominal);
                this.print_saldo();
            }
			else
			{
				Console.WriteLine("Maaf saldo tidak cukup");
			}
        }

		public int get_saldo()
		{
			this.saldo = this.kredit.total() - this.debit.total();
			return this.saldo;
		}
    }
}

