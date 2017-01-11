using System;
namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = KanyeInterruptBuilder("C#", "Java", "immutable parameters");
            Console.WriteLine(text);
            Console.ReadKey();
        }

        static string KanyeInterruptBuilder(string winner, string runnerUp, string talent)
        {
            return string.Format(
                "Yo {0}, I'm really happy for you, I'ma let you finish...{1}...but {2} had one of the best {3} of all time...{1}one of the best {3} of all time.",
                winner,
                Environment.NewLine,
                runnerUp,
                talent);
        }
    }
}
