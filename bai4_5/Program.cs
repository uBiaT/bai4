using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bai4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                    Console.Write("Nhap thang ban muon biet so ngay: ");
                    uint thang = uint.Parse(Console.ReadLine());

                Console.Clear();
                    if (thang <= 12)
                    {
                        TimSoNgay(thang);
                    }
                    else
                    {
                        Console.WriteLine("-> Thang ban nhap khong hop le");
                    }
                Console.WriteLine();

                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static void TimSoNgay(uint thang)
        {
            switch (thang)
            {
                case 1: 
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10:
                case 12:
                    Console.WriteLine($"-> So ngay cua thang {thang} la: 31");
                    break;
                case 4: 
                case 6: 
                case 9: 
                case 11:
                    Console.WriteLine($"-> So ngay cua thang {thang} la: 30");
                    break;
                default:
                    Console.WriteLine($"-> So ngay cua thang {thang} la: 28 hoac 29");
                    Console.Write($"\nNhap nam de biet chinh xac so ngay: ");
                    int nam = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (DateTime.IsLeapYear(nam))
                    {
                        Console.WriteLine($"-> So ngay cua thang {thang} nam {nam} la: 29");
                    }
                    else
                    {
                        Console.WriteLine($"-> So ngay cua thang {thang} nam {nam} la: 28");
                    }
                    break;
            }
        }
    }
}
