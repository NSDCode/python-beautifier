using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace PythonUnpacker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Python Beautifier by Prometheo";
            Console.ForegroundColor = ConsoleColor.Blue;
            animation();
            Console.WriteLine("Python Beautifier /o/");
              string clear = Unpacker.Unpack(args[0]);
              File.WriteAllText($@"{Environment.CurrentDirectory}\Cleared.py", clear);






            void animation()
            {
                Console.WriteLine("[->]");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("[-->]");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("[--->]");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("[---->]");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("[----->]");
                Thread.Sleep(100);
                Console.Clear();
            }
        }













       
    }
}
