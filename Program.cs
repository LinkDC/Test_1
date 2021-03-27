using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test
{
    class Program
    {
       
        class Programе
        {
            static void Main(string[] args)
            {
                int x, y;
                x = 8;
                y = 10;

                if (x - y > 0)
                {
                    x -= y;
                }
                else
                {
                    x = 0;
                }
               
                Console.WriteLine(x);

            }
        }
    }
}
