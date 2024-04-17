//19. Menghitung detak jantung maksimal dan rekomendasi waktu tidur berdasarkan usia
using System;

namespace DetakJantungTidur
{
    class HitungBerdasarkanUsia
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===DETAK JANTUNG MAKSIMAL & REKOMENDASI TIDUR===");
            Console.WriteLine("================BERDASARKAN USIA================");

            Console.Write("Masukkan usia (tahun): ");
            int usia = Convert.ToInt32(Console.ReadLine());

            int detakJantungMaksimal = HitungDetakJantungMaksimal(usia);
            string rekomendasiTidur = RekomendasiWaktuTidur(usia);

            Console.WriteLine($"Untuk seseorang yang berusia {usia} tahun:");
            Console.WriteLine($"Detak jantung maksimal seharusnya: {detakJantungMaksimal} detak per menit");
            Console.WriteLine($"Rekomendasi waktu tidur: {rekomendasiTidur}");
        }

        static int HitungDetakJantungMaksimal(int usia)
        {
            return 220 - usia;
        }

        static string RekomendasiWaktuTidur(int usia)
        {
            if (18 <= usia && usia <= 64)
                return "7-9 jam tidur per malam";
            else if (usia > 65)
                return "7-8 jam tidur per malam";
            else if (14 <= usia && usia < 18)
                return "8-10 jam tidur per malam";
            else if (6 <= usia && usia < 14)
                return "9-11 jam tidur per malam";
            else if (3 <= usia && usia < 6)
                return "10-13 jam tidur per malam";
            else if (1 <= usia && usia < 3)
                return "11-14 jam tidur per malam";
            else if (0.5 <= usia && usia < 1)
                return "12-16 jam tidur per malam";
            else if (usia < 0.5)
                return "14-17 jam tidur per malam";
            else
                return "Usia di luar jangkauan untuk rekomendasi tidur";
        }
    }
}