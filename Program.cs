using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace minmax
{
    internal class Program

    {
        static void Main(string[] args)
        {
            
            Random veletlen = new Random();
            int[] szamok = new int[10];
            for (int i = 0; i < veletlen.Length; i++)
            {
                szamok[i] = veletlen.Next(1,101);
            }


            Console.WriteLine("Generált számok:");
            foreach (int number in szamok)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            int max = szamok[0];
            int min = szamok[0];

            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
            }


            Console.WriteLine($"Legnagyobb szám: {max}");
            Console.WriteLine($"Legnkisebb szám: {min}");
        }
    }
}
