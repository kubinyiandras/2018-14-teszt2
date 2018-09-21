using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfbewiubgfvwe9uibgw
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 feladat
            Console.WriteLine("Első feladat: ");
            int[] tomb1 = new int[10];
            int max1 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Írjob be még {0} számot!", +10-1);
                
                tomb1[i] = Convert.ToInt32(Console.ReadLine());
                if (tomb1[i]>max1)
                {
                    max1 = tomb1[i];
                }
            }
            Console.WriteLine("Legnagyobb szám: "+max1);

            //2. feladat
            Console.WriteLine("Második feladat: ");
            Console.WriteLine("Kérem adja meg hogy hány számot szeretne megadni: ");
            int db = Convert.ToInt32(Console.ReadLine());
            int[] tomb2 = new int[10];
            int max2 = 0;
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Írjob be még {0} számot!", +10 - 1);

                tomb2[i] = Convert.ToInt32(Console.ReadLine());
                if (tomb2[i] > max2)
                {
                    max2 = tomb2[i];
                }
            }
            Console.WriteLine("Legnagyobb szám: " + max2);

 


            Console.ReadLine();
        }
    }
}
