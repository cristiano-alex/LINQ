using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var multiplo3 =
                from inteiro in num
                where
                inteiro % 3 == 0
                select inteiro;

            var outroJeito =
                num.Where(inteiro => inteiro % 3 == 0)
                .Select(inteiro => inteiro);

            foreach (var inteiro in multiplo3)
            {
                Console.WriteLine(inteiro);
            }
            Console.ReadKey();
        }
    }
}
