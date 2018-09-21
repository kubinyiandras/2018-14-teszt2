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
            

            Console.ReadLine();
        }
    }
}
