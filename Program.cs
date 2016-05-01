using System;

namespace MalkoKote
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());

            int sizeKote = (s - 10) / 4 + 1;

            Console.Write(" {0}", ch);
            Console.Write(new string(' ', sizeKote));
            Console.WriteLine("{0} ", ch);

            for (int i = 0; i < sizeKote; i++)
            {
                Console.Write(" ");
                Console.WriteLine(new string(ch, sizeKote + 2));
            }

            for (int i = 0; i < sizeKote; i++)
            {
                Console.Write("  ");
                Console.WriteLine(new string(ch, sizeKote));
            }

            for (int i = 0; i < sizeKote; i++)
            {
                Console.Write(" ");
                Console.WriteLine(new string(ch, sizeKote + 2));
            }

            Console.Write(" ");
            Console.Write(new string(ch, sizeKote + 2));
            Console.Write("   ");
            Console.WriteLine(new string(ch, sizeKote + 1));

            for (int i = 0; i < sizeKote + 2; i++)
            {                
                Console.Write(new string(ch, sizeKote + 4));
                Console.WriteLine("  " + ch);
            }

            Console.Write(new string(ch, sizeKote + 4));
            Console.WriteLine(" " + ch + ch);

            Console.Write(" ");
            Console.WriteLine(new string(ch, sizeKote+5));
        }
    }
}
