using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snoker
{
    class snooker
    {
        static void Main(string[] args)
        {

            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("snooker.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"A világ ranglistán {versenyzok.Count} enyi versenyző szerepel. ");

        }
    }
}
