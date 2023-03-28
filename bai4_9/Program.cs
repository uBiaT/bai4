using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                    Console.Write("Ve tam giac voi n hang: (n)= ");
                    uint n = uint.Parse(Console.ReadLine());

                Console.Clear();
                    Console.WriteLine(VeTamGiac(n));
                Console.WriteLine();

                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static string VeTamGiac(uint n)
        {
            uint hang;
            uint cot;
            string str = "";

            //TAM GIAC VUONG - BEN TRAI
            hang = n;
            cot = n;
            for (uint y = 1; y <= hang; y++)
            {
                for (uint x = 1; x <= cot; x++)
                {
                    if (x <= y)
                    {
                        str += "*";
                    }
                    else
                    {
                        str += "_";
                    }
                }
                str += "\n";
            }
            str += "\n";

            //TAM GIAC VUONG - BEN PHAI
            hang = n;
            cot = n;
            for (uint y = 1; y <= hang; y++)
            {
                for (uint x = 1; x <= cot; x++)
                {
                    if (x > n - y)
                    {
                        str += "*";
                    }
                    else
                    {
                        str += "_";
                    }
                }
                str += "\n";
            }
            str += "\n";

            //TAM GIAC CAN - HUONG LEN
            hang = n;
            cot = (n * 2) - 1;
            for (uint y = 1; y <= hang; y++)
            {
                for (uint x = 1; x <= cot; x++)
                {
                    if (n - y < x & x < n + y)
                    {
                        str += "*";
                    }
                    else
                    {
                        str += "_";
                    }
                }
                str += "\n";
            }
            str += "\n";

            //TAM GIAC CAN - HUONG XUONG
            hang = n;
            cot = (n * 2) - 1;
            for (uint y = 1; y <= hang; y++)
            {
                for (uint x = 1; x <= cot; x++)
                {
                    if (y <= x & x <= (n * 2) - y)
                    {
                        str += "*";
                    }
                    else
                    {
                        str += "_";
                    }
                }
                str += "\n";
            }
            str += "\n";

            return str;
        }
    }
}