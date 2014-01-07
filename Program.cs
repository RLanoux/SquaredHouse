using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquaredHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare constants
            const int LENGTH_OF_HOUSE = 37;
            const int WIDTH_OF_HOUSE = 22;

            //Declare variables
            double squareFeet;

            //Calculate the square footage
            squareFeet = (Double)(LENGTH_OF_HOUSE * WIDTH_OF_HOUSE);

            //Show what the calculation is
            Console.WriteLine("The square footage of a house measuring {0:##} feet by" +
            " {1:##} feet \n\tis {2:####} square feet.", LENGTH_OF_HOUSE, WIDTH_OF_HOUSE, squareFeet);
            Console.ReadLine();

        }
    }
}
