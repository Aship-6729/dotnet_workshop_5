namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // since this print method is static, we can call it without creating an instance of the Printer class
            Printer.Print("Welcome to Method Overloading in C#!");

            Printer printer = new Printer();
            printer.Print(42); // calling through the instance to non-static method to print an integer

            printer.Print("This message will be printed", 3); // calling through the instance to non-static method to print a message and a count.
        }
    }
}
