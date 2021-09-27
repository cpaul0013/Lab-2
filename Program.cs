using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
           bool cont = true;
            Console.WriteLine("Welcome to the DIY genius!");
            while (cont == true)
            {
               
                Console.Write("Please enter the length of the room: ");
                double roomLength = double.Parse(Console.ReadLine());

                Console.Write("Please enter the width of the room: ");
                double roomWidth = double.Parse(Console.ReadLine());

                double roomArea = roomLength * roomWidth;
                Console.WriteLine($"The area of the room is {roomArea}");

                double roomPer = (roomLength * 2) + (roomWidth * 2);
                Console.WriteLine($"The perimeter of the room is {roomPer}");

                double paint = roomPer / 5;
                double carpet = roomArea / 5;

                Console.WriteLine($"You will need {paint} can(s) of paint. \n You will need {carpet} tile(s) of carpet.");
                Console.Write("Would you like to continue? Y/N: ");
                string response = Console.ReadLine();
                if(response == "Y" || response == "y")
                { cont = true; }
                else { cont = false; }
            }
        }
    }
}
