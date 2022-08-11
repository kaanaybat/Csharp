namespace Csharp.Constructor
{
    public class Example
    {
        public Example()
        {
            Console.WriteLine("First constructor !!");
        }

        public Example(string message):this()
        {
            Console.WriteLine(message + " constructor !!");
        }

        public Example(string message,string message2):this(message)
        {
            Console.WriteLine(message2 + " constructor !!");
        }
    }
}