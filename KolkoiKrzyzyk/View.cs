using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkoiKrzyzyk
{
    class View
    {
        public int getCoordinate()
        {
            Console.WriteLine("Podaj wspolrzedna: ");
            return int.Parse(Console.ReadLine());
        }
        public void wypisz(char[,] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length; j++)
                {
                    Console.WriteLine(tab[i,j] + "\t");
                }
            }
        }
    }
}
