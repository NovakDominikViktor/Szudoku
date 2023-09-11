﻿using System;
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

        

            int szam;

            do
            {
                Console.Write("4. feladat: Kérem a feladvány méretét [4..9]: ");

                szam = Convert.ToInt32(Console.ReadLine());
            }
            while (szam < 4 || szam > 9);
        
            List<Feladvany> meretSzerint = new List<Feladvany>();

            foreach(Feladvany feladvanyMeret in feladvanyok)
            {
                if (feladvanyMeret.Meret == szam)
                {
                    meretSzerint.Add(feladvanyMeret);
                }
            }

            if(meretSzerint.Count == 0)
            {
                Console.WriteLine("Nincs ilyen feladvány");
                return;
            }
            else
            {
                Console.WriteLine($"A(z) {szam}x{szam} méretű feladványból {meretSzerint.Count} darab van tárolva");
            }



            Console.ReadKey();
        }
    }
}
