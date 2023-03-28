using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                    Console.Write("Kiem tra so nguyen n la so CHINH PHUONG: (n)= ");
                    uint n = uint.Parse(Console.ReadLine());

                Console.Clear();
                    if (LaSoChinhPhuong(n))
                    {
                        Console.WriteLine($"-> {n} la so CHINH PHUONG");
                    }
                    else
                    {
                        Console.WriteLine($"-> {n} KHONG PHAI la so CHINH PHUONG");
                    }
                Console.WriteLine();

                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static Boolean LaSoChinhPhuong(uint soNguyen)
        {
            double khaiCan = (double)Math.Sqrt(soNguyen);

            if (khaiCan == Math.Floor(khaiCan))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
