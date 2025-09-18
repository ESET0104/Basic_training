namespace DataStructure_Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List Example
            Console.WriteLine("List Demo");
            Console.WriteLine("----------");
            List<Student> students = new List<Student>();

            // Add Student objects to the list
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            // Access and display each student using foreach
            Console.WriteLine("Student List:");
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "ID", "Name", "Marks");
            foreach (Student s in students)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", s.id, s.name, s.marks);
            }

            // Access a specific object by index
            Console.WriteLine($"\nSecond student is: {students[1].name}");
            Console.WriteLine();


            //Dictionay Example
            Console.WriteLine("Dictionary demo");
            Console.WriteLine("---------------");
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);

            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "ID", "Name", "Marks");
            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", student.Value.id, student.Value.name, student.Value.marks);
            }
            Console.WriteLine();


            //Hashset Example
            Console.WriteLine("Hashset demo");
            Console.WriteLine("------------");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "ID", "Name", "Marks");
            foreach (Student student in students_hashset)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", student.id, student.name, student.marks);
            }
            Console.WriteLine() ;

            //StackDemo

            Console.WriteLine("Stack demo");
            Console.WriteLine("----------");
            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "ID", "Name", "Marks");
            while (students_stack.Count > 0) {
                Student pop_stack = students_stack.Pop();
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", pop_stack.id, pop_stack.name, pop_stack.marks);
            }
            Console.WriteLine();
            


            //Queue demo
            Console.WriteLine("Queue demo");
            Console.WriteLine("----------");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "ID", "Name", "Marks");
            while (students_queue.Count > 0)
            {
               
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", students_queue.Dequeue().id, students_queue.Dequeue().name, students_queue.Dequeue().marks);
            }
            Console.WriteLine();


            //LinkedList demo
            Console.WriteLine("LinkedList demo");
            Console.WriteLine("---------------");
            LinkedList<Student> students_list = new LinkedList<Student>();
            students_list.AddLast(first);
            students_list.AddLast(second);
            students_list.AddLast(third);

            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "ID", "Name", "Marks");
            foreach (Student student in students_list) {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", student.id, student.name, student.marks);
            }
            Console.WriteLine();

            //Tuple demo
            Console.WriteLine("Tuple Demo");
            Console.WriteLine("----------");
            Tuple<int, string, int> student1 = new Tuple<int, string, int> (first.id, first.name, first.marks );
            Tuple<int, string, int> student2 = new Tuple<int, string, int> (second.id, second.name, second.marks );
            Tuple<int, string, int> student3 = new Tuple<int, string, int> (third.id, third.name, third.marks );

            List<Tuple<int, string, int>> TupleList = new List<Tuple<int, string, int>> { student1, student2 , student3 };

            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "ID", "Name", "Marks");
            foreach (Tuple<int, string, int> tupler in TupleList)
            {
                Console.WriteLine (tupler.Item1);
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", tupler.Item1, tupler.Item2, tupler.Item3);
            }
        }
    }
}
