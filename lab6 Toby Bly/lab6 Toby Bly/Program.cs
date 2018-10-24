using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_Toby_Bly
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                speedlimit;
            int
                speed;
            speedlimit = 35;
            speed = 42;
            if (speed > speedlimit)
                Console.Write("SLOW NOW");
                

            Console.WriteLine("Enter Temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine()); //user input of fahrenheit
            double celsius = (fahrenheit - 32d) * 5.0 / 9.0;
            Console.WriteLine("The Temperature in Celsius is:" + celsius); //output in Celsius
            if (celsius < 40)
                Console.WriteLine("it is COLD");
            else
                Console.WriteLine("it is HOT");
            Console.ReadLine();

            int i = 1;
            while (i < 11)
            {
                Console.Write("While Output:");
                Console.WriteLine(i);
                i++;

                
            }

            int p = 60;
            while (p >= 20)
            {
                Console.Write("While Output:");
                Console.WriteLine(p);
                p--;



            }
            int j = 10;
            while (j <= 20)
            {
                Console.Write("While Output:");
                Console.WriteLine(j);
                j++;
            }
            
            
            
               
                
                
            

            
            
            
               
                
                
            







        }
    }
}
