using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*16. Имеется 100 рублей.Сколько быков, коров и телят 
    можно купить на все эти деньги, если плата за быка 
    – 10 рублей, за корову – 5 рублей, за теленка – полтинник 
    (0,5 рубля) и надо купить 100 голов скота? */

namespace Lab_3_2_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)            
                for (int j = 0; j < 100; j++)                
                    for (int k = 0; k < 100; k++)                    
                        if (i*10 + j*5 + k*0.5 == 100)
                            Console.WriteLine($"быков - {i} коров - {j}, телят - {k}");            
            Console.ReadKey();
        }
    }
}
