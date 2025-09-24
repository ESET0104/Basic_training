namespace Interface_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adobe adobe = new Adobe();
            Printer printer = new Printer();
            adobe.print();
            printer.print();
        }
    }
}
