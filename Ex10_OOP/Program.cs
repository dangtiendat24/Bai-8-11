using System.Text;

namespace Ex10_OOP
{
    internal class Program
    {
        public struct Student()
        {
            public string Name;
            public double Grade;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            Student[] student = new Student[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin của sinh viên thứ {i+1}: ");
                Console.Write("Tên: ");
                string name = Console.ReadLine();
                Console.Write("Điểm: ");
                double grade = double.Parse( Console.ReadLine());
                student[i] = new Student { Name = name, Grade = grade };
            }

            Console.WriteLine("Hiển thị thông tin sinh viên");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Sinh viên thứ {i + 1}: {student[i].Name}, Điểm {student[i].Grade} ");
            }
            double totalGrade = 0;
            foreach(var x in student)
            {
                totalGrade += x.Grade;
            }
            double AverageGrade = totalGrade / n;
            Console.WriteLine($"Điểm trung bình của cả lớp là: {AverageGrade}");
        }
    }
}
