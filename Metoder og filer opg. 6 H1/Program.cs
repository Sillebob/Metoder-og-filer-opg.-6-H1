using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metoder_og_filer_opg._6_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 6: Enumerate filer i en mappe

            Directory.CreateDirectory(@".\Droids\Astromech");//Opretter undermappe
            Directory.CreateDirectory(@".\Droids\Protocol");//Opretter undermappe
            File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep bop");//opretter fil og tekst i undermappen
            File.WriteAllText(@".\Droids\Protocol\C3PO.txt", "sir");//opretter fil og tekst i undermappen

            string[] files = Directory.GetFiles(@".\Droids", "*", SearchOption.AllDirectories);/*Husk at både stjernen (for filerne) og 
                                                                                                * SearchOption.AllDirectories skal med*/
            foreach (string file in files)
            {
                Console.WriteLine(file);//Udskriver hvilke tekstfiler der ligger i mappen Droids og dens undermapper
            }



            Console.ReadKey();

        }
    }
}
