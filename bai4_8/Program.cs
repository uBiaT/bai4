using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                    Console.Write("Xuat cac so nguyen to tu 2 den n: (n)= ");
                    uint n = uint.Parse(Console.ReadLine());

                Console.Clear();
                    Console.WriteLine($"-> Cac so nguyen to tu 2 toi {n} la: ");
                    for (uint i = 2; i <= n; i++)
                    {
                        if (LaSoNguyenTo(i))
                        {
                            Console.Write($"{i}\t");
                        }
                    }    
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static Boolean LaSoNguyenTo(uint soNguyen)
        {
            Boolean check = true;
            for (int i = 2; i < soNguyen; i++)
            {
                if (soNguyen % i == 0)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
    }
}
