using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu:");
            string input = Console.ReadLine();
            string[] rijeci = input.Split(' ');
            List<string> listaRijeci = new List<string>();
            foreach (string rijec in rijeci)
            {
                listaRijeci.Add(rijec);
            }

            Console.WriteLine("Obrnuti ispis unesenoga je {0}", Okreni(listaRijeci));

            Console.ReadKey();

        }
        static string Okreni(List<string> a)
        {
            string okrenuto = "";
           foreach (string b in a)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    okrenuto = b[i] + okrenuto;
                }
            }
           return okrenuto;
        }
    }
}
