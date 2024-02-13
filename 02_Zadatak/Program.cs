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
            Console.WriteLine("Unesite listu brojeva, razdvoji ih razmakom:");
            string brojevi = Console.ReadLine();
            string[] input = brojevi.Split(' ');
            List<int> listaRijeci = new List<int>();

            foreach (var broj in input)
            {
                listaRijeci.Add(int.Parse(broj));
            }
          
            List<int> novaLista = Okreni(listaRijeci);

            Console.WriteLine("Obrnuti ispis unesenoga je:");
            foreach (var nova in novaLista)
            { Console.Write(nova.ToString()+" " );}

            Console.ReadKey();

        }
        static List<int> Okreni(List<int> a)
        {
            List<int> Okrenuti = new List<int>();
            string temp = "";
            int temp1 = 0;
            a.Reverse();
            foreach (int c in a)
            {
                temp1 = c;
                while (temp1 > 0)
                {
                    temp += (temp1 % 10).ToString();
                    temp1 = temp1 / 10;
                }
                Okrenuti.Add(int.Parse(temp));
                temp = "";

            }
            return Okrenuti;
            
            
        }
    }
}