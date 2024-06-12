using System.Text;

namespace Ex8_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("LỰA CHỌN");
            Console.WriteLine("a. Hiển thị bảng mã ASCII");
            Console.WriteLine("b. Hiển thị bảng mã UTF8 (bảng mã 65001)");
            Console.WriteLine("c. Phát tiếng beep khi nhấm space");
            Console.WriteLine("d Đếm số lần xuất hiện của mỗi kí tự trong chuỗi và hiển thị kết quả đếm");
            Console.Write("Nhập lựa chọn của bạn: ");
            char input = char.Parse(Console.ReadLine());

            switch (input)
            {
                case 'a':
                    DisplayASCIITable();
                    break;
                case 'b':
                    DisplayUTF8Table();
                    break;
                case 'c':
                    PlayBeepOnSpace();
                    break;
                case 'd':
                    CountCharacterOccurrences();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ");
                    break;
            }

            static void DisplayASCIITable()
            {
                Console.WriteLine("Bảng mã ASCII: ");
                for (int i = 0; i < 128; i++)
                {
                    Console.WriteLine($"Mã ASCII {i}, kí tự: {(char)i}");
                }
            }

            static void DisplayUTF8Table()
            {
                Console.WriteLine("Bảng mã UTF8 (trang mã 65001): ");
                for (int i = 32; i <= 126; i++)
                {
                    Console.WriteLine($"Mã UTF8 {i}, kí tự: {(char)i}");
                }
            }

            static void PlayBeepOnSpace()
            {
                Console.WriteLine("Nhấn Space để phát tiếng beep. Nhấn escapce để thoát: ");
                while (true)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Spacebar)
                    {
                        Console.Beep();
                    }
                    else if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }

            static void CountCharacterOccurrences()
            {
                Console.WriteLine("Nhập chuỗi kí tự từ bàn phím: ");
                string input = Console.ReadLine();
                Dictionary<char, int> charCount = new Dictionary<char, int>();
                foreach (char c in input)
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
                Console.WriteLine("Số lần xuất hiện của kí tự");
                foreach(var c in charCount)
                {
                    Console.WriteLine($"Kí tự '{c.Key}': {c.Value} lần");
                }
            }
        }
    }
}
