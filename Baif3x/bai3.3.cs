using System;
using System.Collections.Generic;

namespace ConsoleMenuApp
{
    public class NumberTheory
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static bool IsPerfectNumber(int n)
        {
            if (n <= 1) return false;
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0) sum += i;
            return sum == n;
        }

        static void PrintFibonacci(int n)
        {
            if (n <= 0) return;
            long a = 0, b = 1;
            List<long> list = new List<long>();
            for (int i = 0; i < n; i++)
            {
                list.Add(a);
                long next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine($"Dãy Fibonacci {n} số: {string.Join(", ", list)}");
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("BÀI 3.3: KIỂM TRA SỐ & DÃY FIBONACCI");
            Console.Write("Nhập vào số nguyên dương N: ");
            int n = int.Parse(Console.ReadLine());

            if (IsPerfectNumber(n))
                Console.Write($"{n} là Số hoàn hảo! ");
            else
                Console.Write($"{n} KHÔNG là Số hoàn hảo! ");

            if (IsPrime(n))
                Console.Write($"{n} là Số nguyên tố. ");
            else
                Console.Write($"{n} KHÔNG là Số nguyên tố. ");

            PrintFibonacci(n);

            Console.ReadKey();
        }
    }
}