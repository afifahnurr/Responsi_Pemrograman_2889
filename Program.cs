using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
			
			Console.WriteLine("\t\t\tPilih Menu Aplikasi\n");
			Console.WriteLine("\t\t\t====================\n");
			
			Console.WriteLine("\n1. Tambah Penjualan");
			Console.WriteLine("2. Hapus Penjualan");
			Console.WriteLine("3. Tampilkan Penjualan");
			Console.WriteLine("4. Keluar");
			
			Console.WriteLine("Nomor Menu[1/2/3/4]");
			
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();
			
			Console.Write("Nota:");
			nota=int.Parse(Console.ReadLine());
			
			Console.Write("Tanggal:");
			tanggal=Console.ReadLine();
			
			Console.Write("Customer:");
			nama=Console.ReadLine();
			
			Console.Write("Jenis[T/K]:");
			jenis=char.Parse(Console.ReadLine());
			
			Console.Write("Total Nota:");
			total=double.Parse(Console.ReadLine());
			
			daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Nama = nama, Jenis = jenis, Total = total });
			
			Console.WriteLine("Data berhasil ditambahkan!")

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
			
			int hapus;
            int x = 0;
			
            Console.WriteLine("Hapus Data Penjualan");
            Console.Write("Nota:");
            hapus = int.Parse(Console.ReadLine());
            
			foreach(Penjualan penjual in daftarPenjualan)
            {
                if(hapus==penjual.Nota)
                {
                    daftarPenjualan.RemoveAt(x);
                    break;
                }
                x++;
            }
            
            Console.WriteLine("Data penjualan berhasil dihapus!");

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
			
			int no = 1;
            Console.WriteLine("Data Penjualan\n");

            foreach(Penjualan penjualan in daftarPenjualan)
            {
				
                if(penjualan.Jenis=='T' || penjualan.Jenis=='t')
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}, Tunai, {4}",no,penjualan.Nota,penjualan.Tanggal,penjualan.Nama,penjualan.Total);
                }

                else if(penjualan.Jenis=='K' || penjualan.Jenis=='k')
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}, Kredit, {4}", no, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.Total);
                }

                no++;
				
            }


            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
