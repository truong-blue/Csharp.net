using System;

namespace ConsoleMenuApp
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("BÀI 3.1: MÁY TÍNH CƠ BẢN");
            Console.Write("Nhập a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập phép toán (+, -, *, /, %): ");
            char op = Console.ReadLine()[0];

            string ketQua;
            switch (op)
            {
                case '+':
                    ketQua = $"{a + b:F2}";
                    break;
                case '-':
                    ketQua = $"{a - b:F2}";
                    break;
                case '*':
                    ketQua = $"{a * b:F2}";
                    break;
                case '/' when b == 0:
                case '%' when b == 0:
                    ketQua = "Lỗi: Không thể chia cho 0!";
                    break;
                case '/':
                    ketQua = $"{a / b:F2}";
                    break;
                case '%':
                    ketQua = $"{a % b:F2}";
                    break;
                default:
                    ketQua = "Phép toán không hợp lệ!";
                    break;
            }

            Console.WriteLine($"Kết quả: {ketQua}");
            Console.ReadKey();
        }
    }
}