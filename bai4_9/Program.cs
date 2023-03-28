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
            Console.WriteLine("<----------------------INPUT---------------------->");
            Console.Write("Nhap so nguyen duong: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine();

            uint hang = 0;
            uint cot = 0;
            string str = "";

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

            //TAM GIAC CAN - HUONG TRAI
            hang = (n * 2) - 1;
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


            Console.WriteLine("<----------------------OUTPUT--------------------->");
            Console.WriteLine(str);
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("Nhan phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}