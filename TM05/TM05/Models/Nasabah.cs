using System;
namespace TM05.Models
{
	public class Nasabah
	{
		public string nik, nama, alamat;
		private decimal jml_tabungan;

		public Nasabah(string _nik, string _nama, string _alamat)
		{
			this.nik = _nik;
			this.nama = _nama;
			this.alamat = _alamat;
		}

		public void update_nama()
		{
			Console.WriteLine("Masukkan NIK: ");
			string chl_nik = Console.ReadLine();

			if(this.nik==chl_nik)
			{
                Console.WriteLine("Masukkan Nama: ");
                this.nama = Console.ReadLine();
				Console.WriteLine("Perubahan nama berhasil -> " + this.nama);
			}
		}

        public void update_alamat()
        {
            Console.WriteLine("Masukkan NIK: ");
            string chl_nik = Console.ReadLine();

            if (this.nik == chl_nik)
            {
                Console.WriteLine("Masukkan Alamat: ");
                this.alamat = Console.ReadLine();
                Console.WriteLine("Perubahan alamat berhasil -> " + this.alamat);
            }
        }

		public void print()
		{
			Console.WriteLine("Nama: "+this.nama);
            Console.WriteLine("Alamat: " + this.alamat);
        }

	}
}

