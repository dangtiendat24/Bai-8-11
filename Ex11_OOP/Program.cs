using System.Text;

namespace Ex11_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.Write("Nhập tên file: ");
                string fileName = Console.ReadLine();

                Console.Write("Nhập nội dung file: ");
                string content = Console.ReadLine();

                File.WriteAllText(fileName, content, Encoding.UTF8);
                Console.WriteLine("Nội dung đã được ghi vào file");

                string readContent = File.ReadAllText(fileName, Encoding.UTF8);
                Console.WriteLine("Nội dung đọc từ file là: ");
                Console.WriteLine(readContent);
            }catch(Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi " +  ex.Message);
            }
        }
    }
}
