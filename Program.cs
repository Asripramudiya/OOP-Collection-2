using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolyDanCol
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap[] karyawanTetap = new KaryawanTetap[25];
            KaryawanHarian[] karyawanHarian = new KaryawanHarian[25];
            Sales[] sales = new Sales[25];

            List<Karyawan> listkaryawan = new List<Karyawan>();

            int p1,p2;
            int i = 0, j= 0, k= 0;
            do
            {
                menu:
                Console.WriteLine("Pilih Menu Aplikasi\n");
                Console.WriteLine("\n1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");

                Console.Write("Nomor Menu [1..4] : ");
                p1 = Convert.ToInt32(Console.ReadLine());

                switch (p1)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Tambahkan Data Karyawan\n");
                            Console.WriteLine("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales]");
                            Console.Write("Karyawan yang akan ditambah : ");
                            p2 = Convert.ToInt32(Console.ReadLine());

                            switch (p2)
                            {
                                case 1:

                                    i++;
                                    karyawanTetap[i] = new KaryawanTetap();

                                    Console.WriteLine("\nMasukkan Data Karyawan Tetap");
                                    Console.Write("Nik          : ");
                                    karyawanTetap[i].Nik = Console.ReadLine();
                                    Console.Write("Nama         : ");
                                    karyawanTetap[i].Nama = Console.ReadLine();
                                    Console.Write("Gaji Bulanan : ");
                                    karyawanTetap[i].GajiBulanan = int.Parse(Console.ReadLine());
                                    listkaryawan.Add(karyawanTetap[i]);
                                    Console.WriteLine("\nTekan tombol enter untuk kembali ke Menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto menu;

                                case 2:

                                    j++;
                                    karyawanHarian[j] = new KaryawanHarian();

                                    Console.WriteLine("\nMasukkan Data Karyawan Harian");
                                    Console.Write("Nik              : ");
                                    karyawanHarian[j].Nik = Console.ReadLine();
                                    Console.Write("Nama             : ");
                                    karyawanHarian[j].Nama = Console.ReadLine();
                                    Console.Write("Jumlah jam kerja : ");
                                    karyawanHarian[j].JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Upah per jam     : ");
                                    karyawanHarian[j].UpahPerJam = Convert.ToDouble(Console.ReadLine());
                                    listkaryawan.Add(karyawanHarian[j]);
                                    Console.WriteLine("\nTekan tombol enter untuk kembali ke Menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto menu;

                                case 3:

                                    k++;
                                    sales[k] = new Sales();

                                    Console.WriteLine("\nMasukkan Data Sales");
                                    Console.Write("Nik              : ");
                                    sales[k].Nik = Console.ReadLine();
                                    Console.Write("Nama             : ");
                                    sales[k].Nama = Console.ReadLine();
                                    Console.Write("Jumlah Penjualan : ");
                                    sales[k].JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Komisi           : ");
                                    sales[k].Komisi = Convert.ToDouble(Console.ReadLine());
                                    listkaryawan.Add(sales[k]);
                                    Console.WriteLine("\nTekan tombol enter untuk kembali ke Menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto menu;

                                case 4 :
                                    Console.Clear();
                                    goto menu;

                            }
                        
                        }
                        while (p2 != 4);
                        Console.Clear();
                        goto menu;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Hapus Data Karyawan\n");
                        Console.Write("Nik  : ");
                        string hapus = Console.ReadLine();
                        if (listkaryawan.Any(n => n.Nik == hapus))
                        {
                            listkaryawan.RemoveAll(x => x.Nik == hapus);
                            Console.WriteLine("Data karyawan berhasil dihapus");
                        }
                        else
                        {
                            Console.WriteLine("Data tidak ditemukan\n");
                        }
                        Console.WriteLine("\nTekan tombol enter untuk kembali ke Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3 :
                        Console.Clear();
                        Console.WriteLine("Tampil Data Karyawan\n");
                        int noUrut = 0;


                        foreach (Karyawan karyawan in listkaryawan)
                        {
                            noUrut++;
                            Console.Write("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0} | ",                                   
                                noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                            if (karyawan is KaryawanTetap)

                            {
                                Console.Write("Karyawan Tetap\n");
                            }
                            else if (karyawan is KaryawanHarian)
                            {
                                Console.Write("Karyawan Harian\n");
                            }
                            else if (karyawan is Sales)
                            {
                                Console.Write("Sales\n");
                            }
                        }
                        Console.WriteLine("\nTekan tombol enter untuk kembali ke Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("tidak ditemukan");
                        break;
                }
            }
            while (p1 != 4) ;
            Environment.Exit(0);
        }
    }
}
