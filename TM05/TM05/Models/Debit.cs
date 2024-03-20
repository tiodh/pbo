﻿using System;
namespace TM05.Models
{
	public class Debit
	{
        private List<string> tgl_transaksi = new List<string>();
        private List<int> nominal_transaksi = new List<int>();

        public Debit()
        {
        }

        public void add(int _nominal)
        {
            if (_nominal > 50000)
            {
                DateTime today = DateTime.Today;
                tgl_transaksi.Add(today.ToString());
                nominal_transaksi.Add(_nominal);
            }
            else
            {
                Console.WriteLine("Nominal setor kurang dari batas minimal (50000)");
            }
        }

        public int total()
        {
            int total = 0;
            nominal_transaksi.ForEach(nominal => {
                total += nominal;
            });
            return total;
        }
    }
}

