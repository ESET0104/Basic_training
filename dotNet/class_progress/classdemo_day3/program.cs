namespace classdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student first = new student(10, "abcd", 18, "1234567890", "xyz" );
            student second = new student();
            first.showDisplay();
            second.initialize();
            second.showDisplay();
        }
    }
}