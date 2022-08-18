using System;

namespace ConsoleCalculator
{
    public class DefaultConsole : IConsole
    {
        public string ReadLine() => Console.ReadLine();

        public void Write(string input)
        {
            Console.Write(input);
        }

        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }

        public void WriteLine(string input, params object[] args)
        {
            Console.WriteLine(input, args);
        }
    }
}
