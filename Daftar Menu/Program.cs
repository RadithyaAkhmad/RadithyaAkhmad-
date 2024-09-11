using System;
using System.Collections.Generic;

namespace AplikasiPemesananMakanan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kamus untuk menyimpan harga menu
            Dictionary<string, int> menuHarga = new Dictionary<string, int>
            {
                {"1a", 12000}, {"1b", 9000}, {"1c", 8000}, {"1d", 8000}, {"1e", 9000}, {"1f", 13000},
                {"2a", 5000}, {"2b", 4000}, {"2c", 4000}, {"2d", 5000}, {"2e", 3000}, {"2f", 0}
            };

            // Tampilkan menu
            Console.WriteLine("MENU PESANAN");
            Console.WriteLine("1. Makanan");
            Console.WriteLine("   a. Nasi Goreng  = Rp. 12.000,-");
            Console.WriteLine("   b.Nasi Uduk  = Rp. 9.000");
            Console.WriteLine("   c.asi Kucing  = Rp. 8.000");
            Console.WriteLine("  d.Mie Rebus  = Rp. 8.000");
            Console.WriteLine("  e.Mie Goreng  = Rp. 9.000");
            Console.WriteLine("  f.Mie Ayamm = Rp. 13.000");
            // ... (tambahkan menu lainnya)
            Console.WriteLine("2. Minuman");
            Console.WriteLine("  a.Teh Botol= Rp. 5.000");
            Console.WriteLine("  b.Teh pucuk= Rp. 4.000");
            Console.WriteLine(" c.susu jahe= Rp. 3.000");
            Console.WriteLine(" d.Teh Botol= Rp. 3.000");
            Console.WriteLine("  e.Teh Botol= Rp. 5.000");
            Console.WriteLine("  f.Teh Botol= Rp. free");
            // ... (tambahkan menu minuman)

            // Input pesanan
            Console.Write("Kode Menu: ");
            string kodeMenu = Console.ReadLine();
            Console.Write("Berapa Banyak yang dipesan: ");
            int jumlahPesanan = int.Parse(Console.ReadLine());

            // Hitung total harga
            if (menuHarga.ContainsKey(kodeMenu))
            {
                int hargaSatuan = menuHarga[kodeMenu];
                int totalHarga = hargaSatuan * jumlahPesanan;

                // Tampilkan rincian pesanan
                Console.WriteLine("Rincian Pesanan:");
                Console.WriteLine("Kode Menu: " + kodeMenu);
                Console.WriteLine("Jumlah Pesanan: " + jumlahPesanan);
                Console.WriteLine("Total Harga: Rp. " + totalHarga);
            }
            else
            {
                Console.WriteLine("Kode menu tidak ditemukan.");
            }

            Console.ReadLine();
        }
    }
}
