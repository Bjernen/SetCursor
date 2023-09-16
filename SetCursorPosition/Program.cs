using System;
using System.Threading;

namespace SetCursorPosition
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            void WriteAt(int x, int y, String text)
            {
                Console.SetCursorPosition(x,y);
                Console.WriteLine(text);
            }
            WriteAt(5,5, "\tDette er en test...");
            
            
            for (int i = 0; i < 10; i++)
            {
                WriteAt(4, 5, i.ToString());
                WriteAt(4, 6, i.ToString());
                WriteAt(4, 7, i.ToString());
                Thread.Sleep(1000);
            }


        }
        
    }
}