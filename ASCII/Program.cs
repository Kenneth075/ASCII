using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's create some ASCII art !");
            Console.WriteLine();

            Console.WriteLine("Solid Rectangle");

            int width = 40;
            int height = 15;

            for(int j=0; j<height;  j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Border Rectangle");

            int borderW = 1;
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if(j< borderW || j > height -1- borderW || i< borderW || i> width-1-borderW)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }


            Console.ReadKey();
            
            
            
        }


    }
}
