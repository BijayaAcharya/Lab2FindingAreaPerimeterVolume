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
            Console.ReadLine();

            // using while loop
            while (true)
            {
                Console.WriteLine(" Do you want to continue?, 'y/n'"); // asking user input
                string answer = Console.ReadLine().ToUpper(); // reading from the console and converting user input into upper case
                if (answer == "Y") // condition yes
                {
                } 
                                       /* {
                                            Console.WriteLine("enter the length"); // asking user input
                                            double length1 = double.Parse(Console.ReadLine()); //reading from the console and parsing to double
                                            Console.WriteLine("enter the width"); // asking user input
                                            double width1 = double.Parse(Console.ReadLine()); // reading from the console and pasrsing to double
                                            Console.WriteLine("enter the height");
                                            double height = double.Parse(Console.ReadLine());

                                            double area1 = length1 * width1; // calculating area

                                            double peri1 = (2 * (length1 + width1)); // calculating perimeter
                                            double volume = (length1 * width1* height);

                                            Console.WriteLine("Area of Room is = {0}, Perimeter is ={1}, and volume is {2}", area1, peri1, volume);  // displaying output to the  console
                                            Console.ReadLine(); 

                                        }*/
                                       //if (answer == "N") // condition no
                else
                {
                    break; // exit the program
                }
                Console.ReadLine();
            }
        }
    }
}

            
            

            

            
           


            
       
    
