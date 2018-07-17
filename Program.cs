using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2FindTheAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Grand Circus' Room Detail Generator!");
            while (true)
            {
               
                // asking user input 1
                Console.WriteLine("enter the length");

                //readiing from the console and parsing to double
                double length = double.Parse(Console.ReadLine());

                // asking user input II
                Console.WriteLine("enter the width");

                // reading from the console and parsing to double
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("enter the height");
                double height = double.Parse(Console.ReadLine());

                // calculating area
                double area = length * width;
                // calculating perimeter
                double peri = (2 * (length + width));
                // calculating volume
                double volume = (length * width * height);

                //displaying the output to the console

                Console.WriteLine("Area of Room is = {0}, Perimeter is ={1}, and volume is {2}", area, peri, volume);

                //Console.WriteLine("Area of Room is = {0} and Perimeter is ={1}", area, peri);
                Console.WriteLine("");

                
                Console.WriteLine(" Do you want to continue?, 'y/n'"); // asking user input
                string answer = Console.ReadLine().ToUpper(); // reading from the console and converting user input into upper case
                if (answer == "Y") // condition yes
                {
                }

                else
                {
                    break; // exit the program
                }
                
            }
        }
    }
}













