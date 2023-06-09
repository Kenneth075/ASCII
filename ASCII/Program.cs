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
                    Console.Write("█");
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
            Console.WriteLine();

            Console.WriteLine("Checked Pattern");

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if((i+j)%2 == 0)
                    {
                        Console.Write("█");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Pyramid");

            int pyramidWidth = 2 * height - 1;
            int centreColumn = height - 1;

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < pyramidWidth; i++)
                {
                    if (i >= centreColumn -j && i <= centreColumn + j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Circle");

            double centerX = width/2.0;
            double centerY = height/2.0;
            double radius = 0.0;
            if(height<width)
            {
                radius = 0.5 * height;
            }
            else
            {
                radius = 0.5 * width;
            }

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    double dx = i - centerX;
                    double dy = j - centerY;
                    double distance = Math.Sqrt(dx * dx + dy * dy);

                    if (distance < radius)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }


                }
                Console.WriteLine();

            }
            Console.WriteLine();

            Console.ReadKey();
            
            
        }


    }
}
