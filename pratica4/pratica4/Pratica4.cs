using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica4
{
    internal class Pratica4
    {
        static void Main(string[] args)
        {
            MaxMin maxmin = new MaxMin();
            Random r = new Random();  
            int ma, me;
            int[] vet_random = new int[1000];
            int[] vet_crescente = new int[1000];
            int[] vet_decrescente = new int[1000];

            for (int i = 0; i < vet_random.Length; i++)
            {
                vet_random[i] = r.Next(1000);
                vet_crescente[i] = i;
                vet_decrescente[i] = i - 1000;

            }
            maxmin.MaxMin1(vet_crescente,out ma, out me);
           
            maxmin.MaxMin1(vet_decrescente, out ma, out me);

            maxmin.MaxMin1(vet_random, out ma, out me);
            Console.WriteLine("Número de execuções MaxMin1: " + maxmin.count1);

            maxmin.MaxMin2(vet_crescente, out ma, out me);

            maxmin.MaxMin2(vet_decrescente, out ma, out me);

            maxmin.MaxMin2(vet_random, out ma, out me);
            Console.WriteLine("Número de execuções MaxMin2: " + maxmin.count2);

            maxmin.MaxMin3(vet_crescente, out ma, out me);

            maxmin.MaxMin3(vet_decrescente, out ma, out me);

            maxmin.MaxMin3(vet_random, out ma, out me);
            Console.WriteLine("Número de execuções MaxMin3: " + maxmin.count3);
            int count_final = maxmin.count1 + maxmin.count2 + maxmin.count3;
            Console.WriteLine("Número de execuções final: " + count_final);
        }
    }
}
