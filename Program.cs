using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace baitaptonghop
{
    internal class Program
    {
        class tonghop
        {
            public void bai1()
            {
                int[] arr;
                Console.Write("nhap so luong phan tu trong mang : ");
                int n = Convert.ToInt32(Console.ReadLine());
                arr = new int[n];
                int a = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"nhap phan tu thu {i + 1} : ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    a += arr[i];
                }
                Console.Write($"tong cac phan tu trong mang la : {a}");
            }
            public void bai2()
            {
                Console.Write("nhap chuoi : ");
                string a = Convert.ToString(Console.ReadLine());
                int r = a.Count(a => char.IsLetter(a));
                Console.WriteLine($"so luong ky tu khong bao gom dau cau va khoang cach trong chuoi la : {r}");
            }


            public void bai3()
            {
                int[] arr;
                Console.Write("Nhap so luong phan tu trong mang: ");
                int n = Convert.ToInt32(Console.ReadLine());
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap phan tu thu {i + 1}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                Console.WriteLine($"Phan tu lon nhat trong mang la: {max}");
            }


            public void bai4()
            {
                Console.Write("Nhap chuoi: ");
                string input = Console.ReadLine();

                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);

                string reversed = new string(charArray);
                Console.WriteLine("Chuoi dao nguoc: " + reversed);
            }


            public void bai5()
            {
                int n;
                int[] arr;
                Console.Write("nhap so luong phan tu trong mang :");
                n = Convert.ToInt32(Console.ReadLine());
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap phan tu thu {i + 1}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                bool test = true;
                for (int i = 0; i < n / 2; i++)
                {
                    if (arr[i] != arr[n - 1 - i])
                    {

                        test = false; break;
                    }
                }
                if (test)
                { Console.WriteLine("day la mang doi xung"); }
                else
                {
                    Console.WriteLine("day khong phai mang doi xung");
                }
            }

            public void bai6()
            {
                Console.Write("nhap chuoi : ");
                string a = Convert.ToString(Console.ReadLine());
                Console.Write("nhap ky tu can dem : ");
                char b = Convert.ToChar(Console.ReadLine());
                char[] charArray = a.ToCharArray();
                int l = 0;
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray[i] == b)
                    {
                        l++;
                    }

                }
                Console.WriteLine($"so lan {b} xuat hien trong chuoi la : {l}");
            }
        }
        static void Main(string[] args)
        {
            tonghop tonghop = new tonghop();
            tonghop.bai1();
        }
    }
}


