using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        enum week
        {
            lundi, // mettre lundi = 1
            mardi,
            mercredi,
            jeudi,
            vendredi,
            saemdi,
            dimanche
        }
        static void Main(string[] args)
        {
         // foreach (int i in Enum.GetValues(typeof(week)))
         foreach (string i in Enum.GetNames(typeof(week)))
         Console.WriteLine(i);
         Console.ReadKey();
         Console.WriteLine(Enum.GetName(typeof(week), 4));
            // Console.WriteLine(Enum.ToObject(typeof(week), 0));
         Console.WriteLine("1"+ "\n"+ Enum.GetName(typeof(week),1) + "\n" + Enum.GetName(typeof(week), 2) + "\n" + Enum.GetName(typeof(week), 3) + "\n" + Enum.GetName(typeof(week),4) + "\n" + Enum.GetName(typeof(week), 5) + "\n" + Enum.GetName(typeof(week), 6));
        }
        // week lundi = week.lundi;
        // week mardi = week.mardi;...
        // Console.WriteLine(lundi);
        
    }
}
