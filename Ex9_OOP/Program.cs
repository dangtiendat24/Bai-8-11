using System.Text;

namespace Ex9_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("LỰA CHỌN");
            Console.WriteLine("a. Đảo ngược chuỗi ");
            Console.WriteLine("b. Đếm kí tự trong chuỗi ");
            Console.Write("Nhập lựa chọn của bạn: ");
            char inputUser = char.Parse(Console.ReadLine());

            switch (inputUser)
            {
                case 'a':
                    ReverseString();
                    break;
                case 'b':
                    CountWords();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ");
                    break;
            }

            static void ReverseString()
            {
                Console.WriteLine("Nhập vào một chuỗi: ");
                string inputString = Console.ReadLine();
                char[] charArray = inputString.ToCharArray();
                Array.Reverse(charArray);
                string ReverseString = new string(charArray);
                Console.WriteLine("Chuỗi sau khi đảo ngược là: " +  ReverseString);
            }

            static void CountWords()
            {
                Console.WriteLine("Nhập chuỗi kí tư: ");
                string inputString = Console.ReadLine();
                string[] words = inputString.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Length;
                Console.WriteLine($"Số lượng từ trong chuỗi: {wordCount}");
            }
        }
    }
}
