using System;
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
            Console.WriteLine("<----------------------INPUT---------------------->");
            Console.Write("Nhap mot so nguyen duong: ");
            uint soNguyen = uint.Parse(Console.ReadLine());
            Console.WriteLine();

            double khaiCan = (double)Math.Sqrt(soNguyen);

            Console.WriteLine("<----------------------OUTPUT--------------------->");
            if (khaiCan == Math.Floor(khaiCan))
            {
                Console.WriteLine($"{soNguyen} la so Chinh Phuong");
            }
            else
            {
                Console.WriteLine($"{soNguyen} KHONG PHAI la so Chinh Phuong");
            }
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("Nhan phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
