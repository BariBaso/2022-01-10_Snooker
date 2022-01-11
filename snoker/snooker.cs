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
            foreach (var sor in File.ReadAllLines("snooker.txt").Skip(1))           //feltöptés

            {
                versenyzok.Add(new Versenyzo(sor));
            }



            //3.
            Console.WriteLine($"A világ ranglistán {versenyzok.Count} enyi versenyző szerepel. ");
            //4.
            Console.WriteLine($"A versenyzők átlagosan{versenyzok.Average(x => x.Nyeremeny):0.00} keresterk");
            //5.
            Versenyzo maxV =
            versenyzok
                .Where(v => v.Ország == "Kína")
                .OrderBy(v => v.Nyeremeny)
                .Last();

            Console.WriteLine($"a leggjobban kereső kínai versenyző");
            Console.WriteLine($"\thelyezés: {maxV.Helyezes}");
            Console.WriteLine($"\tnév: {maxV.Név}");
            Console.WriteLine($"\tország: {maxV.Ország}");
            Console.WriteLine($"\tnyeremény: {(maxV.Nyeremeny * 380).ToString("C0")}");

            //6.
            Console.WriteLine($"a versenyzők közőtt {(versenyzok.Any(v => v.Ország == "Norvégia") ? "van" : "nincs") } notvég"); //van e norvéggg

        }
    }
}
