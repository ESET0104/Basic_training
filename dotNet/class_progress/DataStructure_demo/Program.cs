namespace DataStructure_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating list of objects and displaying the fields
            List<Student> student_list = new List<Student>();

            Student S1 = new Student(1, "kamal", "1243");
            Student S2 = new Student(2, "arjun", "1865");
            Student S3 = new Student(3, "preethi", "8755");

            student_list.Add(S1);
            student_list.Add(S2);
            student_list.Add(S3);

            Console.WriteLine("printing the list of objects --");
            Console.WriteLine("{0,-12} {1,-15} {2,-15}", "Student ID", "Student Name", "Contact No");
            Console.WriteLine("---------------------------------------");
            foreach (Student student in student_list) {
                Console.WriteLine("{0,-12} {1,-15} {2,-15}", student.student_id, student.name, student.contactno);
            }

            //creating a list of dictionaries and displaying the values
            Dictionary<string, string> student1 = new Dictionary<string, string>
            {
                {"s_id", "101" },
                {"s_name", "raghu" },
                {"s_contact", "76799" }
            };

            Dictionary<string, string> student2 = new Dictionary<string, string>
            {
                {"s_id", "102" },
                {"s_name", "chandu" },
                {"s_contact", "82367" }
            };

            Dictionary<string, string> student3 = new Dictionary<string, string>
            {
                {"s_id", "103" },
                {"s_name", "ram" },
                {"s_contact", "79643" }
            };

            List<Dictionary<string, string>> student_ = new List<Dictionary<string, string>> { student1, student2, student3};

            Console.WriteLine();
            Console.WriteLine("printing the list of dictionaries-- ");
            Console.WriteLine("{0,-12} {1,-15} {2,-15}", "Student ID", "Student Name", "Contact No");
            Console.WriteLine("---------------------------------------");
            foreach (Dictionary<string, string> student in student_) {
                Console.WriteLine("{0,-12} {1,-15} {2,-15}", student["s_id"], student["s_name"], student["s_contact"]);
            }
        }

    }
}
