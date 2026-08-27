using System;

namespace ConsoleMenuApp
{
    public class QuadraticEquation
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("BÀI 3.2: GIẢI PHƯƠNG TRÌNH BẬC 2");
            Console.Write("Nhập a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine(c == 0 ? "Phương trình có vô số nghiệm." : "Phương trình vô nghiệm.");
                else
                    Console.WriteLine($"Phương trình bậc nhất có nghiệm x = {-c / b:F2}");
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có 2 nghiệm: x1 = {x1:F2}, x2 = {x2:F2}");
                }
                else if (delta == 0)
                {
                    Console.WriteLine($"Phương trình có nghiệm kép: x = {-b / (2 * a):F2}");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }

            Console.ReadKey();
        }
    }
}