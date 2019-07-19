using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();
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
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4:
                        keluar();// keluar dari program
                        return;
                        
                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("======================");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();
            string Nama, Kode;
            int TotalPiutang;   // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Tambah Data Customer\n");

            Console.Write("Kode Customer : ");
            Kode = Console.ReadLine();
            Console.Write("Nama Customer : ");
            Nama = Console.ReadLine();
            Console.Write("Total Piutang : ");
            TotalPiutang = Convert.ToInt32(Console.ReadLine());

            Customer customer = new Customer();
            customer.Kode = Kode;
            customer.Nama = Nama;
            customer.TotalPiutang = TotalPiutang;

            daftarCustomer.Add(customer);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Hapus Data Customer\n");
            Console.Write("Kode Customer : ");
            string kode = Console.ReadLine();

            Customer customer = new Customer();
            customer = daftarCustomer.SingleOrDefault(f => f.Kode == kode);

            if (customer != null)
            {
                daftarCustomer.Remove(customer);
                Console.WriteLine("\nData Customer berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Customer tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();  // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Data Customer\n");
            int no = 1;
            foreach(Customer customer in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}", no, customer.Kode, customer.Nama, customer.TotalPiutang);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }

        static void keluar()
        {
            Console.Clear();
            Console.WriteLine("Program selesai di jalankan");
            Console.ReadKey();
        }
    }
}
