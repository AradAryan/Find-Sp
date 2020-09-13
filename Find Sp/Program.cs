using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Find_Sp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Directory.GetFiles(@"C:\Users\javad\Desktop\Afzal DB Context", "*.Context.cs");
            List<string> names = new List<string>();
            foreach (var item in list)
            {
                var lines = File.ReadAllLines(item);
                foreach (var name in lines.Where(p => p.Contains("SP_Afzal_GetTrRecords")))
                {
                    names.Add(name);
                }
            }

            Console.ReadKey();
        }
    }
}
