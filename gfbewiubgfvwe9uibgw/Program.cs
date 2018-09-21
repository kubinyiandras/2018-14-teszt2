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
                Console.WriteLine("Írjob be még {0} számot!", +10);                
                tomb1[i] = Convert.ToInt32(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(),out tomb1[i]))
                {
                    Console.WriteLine("Nem számot adtál meg kérlek adj meg számot.");
                    Console.ReadLine();
                    return;
                    if (tomb1[i] > max1)

                    {
                        max1 = tomb1[i];
                    }
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

            //3. feladat
            Console.WriteLine("3. feladat");
            int[] tomb3 = new int[10];
            int max3 = 0;
            int min3 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Írjob be még {0} számot!", +10 - 1);

                tomb3[i] = Convert.ToInt32(Console.ReadLine());
                if (tomb3[i] > max3)
                {
                    max3 = tomb3[i];
                }
                if (tomb3[i] > min3)
                {
                    min3 = tomb3[i];
                }

            }
            Console.WriteLine("Legnagyobb szám: " + max3);
            Console.WriteLine("A legkissebb szám a: " + min3);

            //4. feladat
            Console.WriteLine("4. feladat");




            Console.ReadLine();
        }
    }
}
