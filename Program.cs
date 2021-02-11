using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giraph
{
    class Program
    {
        static void Main(string[] args)
        {


            //this Program find derivative
            Console.WriteLine("enter the power of the first part of the eqation: ");
            int pOwer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the NUmber before the letter of the first part of the eqation: ");
            int numbBeforeX = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine("enter the variable (x,y...) :  ");
            string variable = Console.ReadLine();

            int deriVat = pOwer * numbBeforeX;
            int newExpo = pOwer - 1;
            Console.WriteLine("Anything that appear after the variable (No space between example 5x2 =5x with exponent 2) should be treated as ArgumentNullException exponent)");
            Console.WriteLine(deriVat+variable +newExpo);



            Console.ReadLine();


        }
     
    }
}
