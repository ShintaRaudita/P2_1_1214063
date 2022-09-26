using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka1 = int.Parse(Console.ReadLine());
            int angka2 = int.Parse(Console.ReadLine());

            int jumlah;
            int kurang;
            int kali;
            int bagi;

            jumlah = angka1 + angka2;
            kurang = angka1 - angka2;
            kali = angka1 * angka2;
            bagi = angka1 / angka2;

            Console.WriteLine("Angka Pertama = " + angka1);
            Console.WriteLine("Angka Kedua = " + angka2);
            Console.WriteLine($"{angka1} + {angka2} = {jumlah}");
            Console.WriteLine($"{angka1} - {angka2} = {kurang}");
            Console.WriteLine($"{angka1} * {angka2} = {kali}");
            Console.WriteLine($"{angka1} / {angka2} = {bagi}");

            Console.WriteLine($"{angka1} / {angka2} = {bagi}");

        }
    }
}
