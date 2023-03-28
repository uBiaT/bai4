using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.Write("Tinh tong theo cong thuc voi (n)= ");
                    uint n = uint.Parse(Console.ReadLine());

                Console.Clear();
                    Console.WriteLine($"-> Tong cac so tu 1 den {n} theo cong thuc la: {TinhTong(n)}");
                Console.WriteLine();

                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static double TinhTong(uint soNguyen)
        {
            double tong = 0;
            for (double i = 1; i <= soNguyen; i++)
            {
                tong += Math.Pow(i, i);
            }
            return tong;
        }
    }
}
