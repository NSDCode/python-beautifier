using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;

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
            string path = args[0];
            string copy = File.ReadAllText(path);
            copy = copy.Replace("exec", "print");
            Process.Start("cmd.exe", $"/C {path} > extracted.py");
            string newpath = $@"{Environment.CurrentDirectory}\extracted.py";
            Thread.Sleep(5000);
            string clear = Unpacker.Unpack(newpath);
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
