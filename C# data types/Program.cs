using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {// delaration of 4 data types
            string name = "Sisekelo";
            int age = 21;
            bool isshort = true;
                double weight = 60.4;
            char initial = 'S';
            //print out everything to the screen;

           Console.WriteLine("Your name is " + name + " who is  " + age + "years old" + " weighs " + weight + " and is " + isshort); 

           name = "James";
            age = 34;
            isshort = false;
                weight = 90.5;

            Console.WriteLine("Your name is " + name + " who is  " + age + "years old" + " weighs " + weight + " and is " + isshort);















            Console.ReadLine();




        }
    }
}
