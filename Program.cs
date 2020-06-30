using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab8.ClassAnak;
using Lab8.ClassInduk;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Update Tugas Lab 8 Muhammad Fahmi Attaqwa 19.11.2597";
            int input;
            List<Pegawai> listPegawai = new List<Pegawai>();
            do
            {
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine("=========================================");
                Console.WriteLine("1. Tambah Data Pegawai");
                Console.WriteLine("2. Tampilkan Data Pegawai");
                Console.WriteLine("3. Ubah Data Pegawai");
                Console.WriteLine("4. Hapus Data Pegawai");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("=========================================");
                Console.Write("Pilihan (1 sd 5): ");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Tambah Data Pegawai\n");
                        Console.WriteLine("Jenis Pegawai\n1. Pegawai Tetap \n2. Pegawai Harian \n3. Sales ");
                        Console.Write("Pilihan (1 sd 3): ");
                        int pil = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (pil)
                        {
                            case 1:
                                PegawaiTetap PegawaiTetap = new PegawaiTetap();
                                Console.Write("nik : ");
                                PegawaiTetap.nik = Console.ReadLine();
                                Console.Write("nama : ");
                                PegawaiTetap.nama = Console.ReadLine();
                                Console.Write("gaji Bulanan : ");
                                PegawaiTetap.gajibulanan = Convert.ToDouble(Console.ReadLine());
                                listPegawai.Add(PegawaiTetap);
                                break;
                            case 2:
                                PegawaiHarian PegawaiHarian = new PegawaiHarian();
                                Console.Write("nik : ");
                                PegawaiHarian.nik = Console.ReadLine();
                                Console.Write("nama : ");
                                PegawaiHarian.nama = Console.ReadLine();
                                Console.Write("Jumlah Jam Kerja : ");
                                PegawaiHarian.jumlahjamkerja = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Upah Per Jam : ");
                                PegawaiHarian.upahperjam = Convert.ToDouble(Console.ReadLine());
                                listPegawai.Add(PegawaiHarian);
                                break;
                            case 3:
                                Sales Sales = new Sales();
                                Console.Write("nik : ");
                                Sales.nik = Console.ReadLine();
                                Console.Write("nama : ");
                                Sales.nama = Console.ReadLine();
                                Console.Write("Jumlah Jam Kerja : ");
                                Sales.jumlahpenjualan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Upah Per Jam : ");
                                Sales.komisi = Convert.ToDouble(Console.ReadLine());
                                listPegawai.Add(Sales);
                                break;
                            default:
                                Console.WriteLine("Menu Yang Anda Masukkan Salah!!!");
                                break;
                        }
                        break;
                    case 2:
                        int noUrut = 0;
                        string jenis = " ";
                        Console.WriteLine("Data Pegawai\n");
                        foreach (Pegawai pegawai in listPegawai)
                        {
                            if (pegawai is PegawaiTetap)
                            {
                                jenis = "Pegawai Tetap";
                            }
                            else if (pegawai is PegawaiHarian)
                            {
                                jenis = "Pegawai Harian";
                            }
                            else
                            {
                                jenis = "Sales";
                            }
                            noUrut++;
                            Console.WriteLine("No. : {0}", noUrut);
                            Console.WriteLine("NIK : {0}", pegawai.nik);
                            Console.WriteLine("Nama : {0}", pegawai.nama);
                            Console.WriteLine("Gaji : {0}", pegawai.gaji());
                            Console.WriteLine("Jenis Pegawai : {0}", jenis);
                            Console.WriteLine("\n");
                        }
                        if (noUrut < 1)
                        {
                            Console.WriteLine("Data Pegawai Kosong");
                        }
                        break;
                    case 3:
                        int i;
                        Console.WriteLine("Ubah Data Pegawai\n");
                        Console.Write("nik : ");
                        string updatenik = Console.ReadLine();

                        foreach (Pegawai pegawai in listPegawai)
                        {

                            if (pegawai.nik == updatenik)
                            {
                                //for (i = 0; i < sizeof(karyawan.nik); i++)
                                //{
                                Console.WriteLine("NIK : {0}", pegawai.nik);
                                Console.WriteLine("Nama : {0}", pegawai.nama);

                                Console.Write("nik : ");
                                pegawai.nik = Console.ReadLine();
                                Console.Write("nama : ");
                                pegawai.nama = Console.ReadLine();
                                //}
                            }
                            else
                            {
                                Console.WriteLine("\nData tidak ditemukan");
                            }
                        }
                        break;
                    case 4:
                        int no = -1, hapus = -1;
                        Console.WriteLine("Hapus Data Pegawai\n");
                        Console.Write("nik : ");
                        string nik = Console.ReadLine();
                        foreach (Pegawai pegawai in listPegawai)
                        {
                            no++;
                            if (pegawai.nik == nik)
                            {
                                hapus = no;
                            }
                        }
                        if (hapus != -1)
                        {
                            listPegawai.RemoveAt(hapus);
                            Console.WriteLine("\nData Berhasil dihapus");
                        }
                        else
                        {
                            Console.WriteLine("\nData tidak ditemukan");
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak tersedia!");
                        break;
                }
                Console.WriteLine("\nBerhasil !\n");
            }
            while (input != 5);
        }
    }
}