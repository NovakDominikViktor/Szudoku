using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sudokuCLI
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();

            try
            {
                using (StreamReader reader = new StreamReader("feladvanyok.txt"))
                {
                    string sor;
                    
                    while((sor = reader.ReadLine()) != null)
                    {
                        feladvanyok.Add(new Feladvany(sor));
                    }
                }
            
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"3. feladat: Beolvasva {feladvanyok.Count} feladvány ");

            Console.ReadKey();
        }
    }
}
