using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                    Console.Write("Kiem tra so nguyen n chia het cho 3: (n)= ");
                    int n = int.Parse(Console.ReadLine());

                Console.Clear();
                    if (ChiaHetCho3(n))
                    {
                        Console.WriteLine($"-> {n} chia het cho 3");
                    }
                    else
                    {
                        Console.WriteLine($"-> {n} KHONG chia het cho 3");
                    }
                Console.WriteLine();

                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static Boolean ChiaHetCho3(int soNguyen)
        {
            if (soNguyen % 3 == 0)
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
