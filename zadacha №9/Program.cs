using System.Diagnostics;

namespace zadacha__9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] massive = Process.GetProcesses();
            int max = (massive.Count() - 1);
            int pos = 0; 
            ConsoleKeyInfo a = Console.ReadKey();
            foreach (Process s in massive)
            {
                Console.WriteLine("  " + s.ProcessName);
            }
            while(a.Key != ConsoleKey.Enter)
            {
                if(a.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    Console.SetCursorPosition(0, pos + 1);
                }
                if(a.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    Console.SetCursorPosition(0, pos - 1);
                }
                if(pos < 0)
                {
                    pos++;
                    Console.SetCursorPosition(0, pos);
                }
                if(pos > max)
                {
                    pos--;
                    Console.SetCursorPosition(0, pos);
                }
                Console.WriteLine("  ");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                a = Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Это все что я смог сделать");
            
            
           
       

        }
    }
}