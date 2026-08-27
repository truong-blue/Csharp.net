using System;

namespace ConsoleMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int luaChon;

            do
            {
                Console.Clear();
                Console.WriteLine("CHƯƠNG TRÌNH TỔNG HỢP");
                Console.WriteLine(" 1. Chạy Bài 3.1 (Calculator)");
                Console.WriteLine(" 2. Chạy Bài 3.2 (Phương trình bậc 2)");
                Console.WriteLine(" 3. Chạy Bài 3.3 (Số nguyên tố & Fibonacci)");
                Console.WriteLine(" 0. Thoát chương trình");
                Console.Write("Nhập lựa chọn của bạn (0 - 3): ");

                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    luaChon = -1;
                }

                Console.Clear();

                switch (luaChon)
                {
                    case 1:
                        Calculator.Main(null);
                        break;
                    case 2:
                        QuadraticEquation.Main(null);
                        break;
                    case 3:
                        NumberTheory.Main(null);
                        break;
                    case 0:
                        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình! Tạm biệt.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                if (luaChon != 0)
                {
                    Console.Write("Nhấn phím bất kỳ để quay lại Menu chính...");
                    Console.ReadKey();
                }

            } while (luaChon != 0);
        }
    }
}