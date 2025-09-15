namespace classdemo
{
    internal class student
    {
        private int student_id;
        public string name;
        int age;
        string contactno;
        string emailid;

        public void initialize()
        {
            student_id = 10;
            name = "abcd";
        }

        public void showDisplay()
        {
            Console.WriteLine("displaying object");
            Console.WriteLine(name);
        }

        public student() { }

        public student(int std_id, string std_name, int std_age, string std_contact, string std_email)
        {
            student_id = std_id;
            name = std_name;
            age = std_age;
            contactno = std_contact;
            emailid = std_email;
        }

        public void getTotal()
        {

        }

        
    }
}