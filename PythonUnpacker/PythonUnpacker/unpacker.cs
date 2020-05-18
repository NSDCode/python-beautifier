using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Unpacker
{
    public static string Unpack(string source)
    {
        string code = File.ReadAllText(source);
        int chars = 0;
        foreach (char c in code)
        {
            chars++;
        }
        for (int i=0; i < chars; i++)
        {
            code = code.Replace(@"\n", Environment.NewLine);
            code = code.Replace(@"\r\", Environment.NewLine);
        }
        return code;
    }



}

