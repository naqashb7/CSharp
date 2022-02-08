using System;

namespace Calculator;

class Calculator
{

    static void Main(string[] args)

    {
        Console.WriteLine("Are you painting walls?");
        string walls = Console.ReadLine();
        Console.WriteLine("Are you painting doors?");
        string doors = Console.ReadLine();  
        Console.WriteLine("Are you painting windows?");
        string windows = Console.ReadLine();
        Console.WriteLine("Are you painting ceilings?");
        string ceilings = Console.ReadLine();   



        //total up wall area
        if (walls.ToLower() != "no")
        {
            Console.WriteLine("How many walls will you be painting?");
            int totalwalls = Convert.ToInt32(Console.ReadLine());
            if (totalwalls > 1)
            {
                Console.WriteLine("Are all the walls the same size?");
                string wallSizeSame = Console.ReadLine();
                if (wallSizeSame.ToLower() != "yes")
                {
                   for(int i = 0; i <= totalwalls; i++)
                    {
                        Console.WriteLine("What is the height of the area you will be painting in metres? (please enter a number)");
                        double wallsheight = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the width of the area you will be painting in metres? (please enter a number");
                        double wallswidth = Convert.ToDouble(Console.ReadLine());
                    }

                }
            }
            else
            {
                Console.WriteLine("What is the height of the area you will be painting in metres? (please enter a number)");
                double wallsheight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the width of the area you will be painting in metres? (please enter a number");
                double wallswidth = Convert.ToDouble(Console.ReadLine());
            }
        }
        else
        {
            Console.WriteLine("You have entered that you will not be painting any walls");
        }
        if (doors.ToLower() != "no")
        {
            Console.WriteLine("How many doors will you be painting?");
            int totaldoors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the area you will be painting? (please enter a number)");
            double doorsheight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the width of the area you will be painting? (please enter a number");
            double doorswidth = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("You have entered that you will not be painting any doors");
        }
        if (windows.ToLower() != "no")
        {
            Console.WriteLine("How many doors will you be painting?");
            int totalwindows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the area you will be painting? (please enter a number)");
            double windowsheight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the width of the area you will be painting? (please enter a number");
            double windowswidth = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("You have entered that you will not be painting any windows");
        }
        if (ceilings.ToLower() != "no")
        {
            Console.WriteLine("How many ceilings will you be painting?");
            int totalceilings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the area you will be painting? (please enter a number)");
            double ceilingsheight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the width of the area you will be painting? (please enter a number");
            double ceilingswidth = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("You have entered that you will not be painting any ceilings");
        }




        /*Console.WriteLine("You can pick from the following colours: Red, Blue, Yellow, Green, Pink, Violet or Indigo");
        //value of each paint colour
        double red = 5.00;
        double blue = 2.00;
        double yellow = 4.00;
        double green = 3.50;
        double pink = 4.50;
        double violet = 5.50;
        double indigo = 2.40;



        Console.WriteLine("What colour would you like to buy?");
        string selectedPaintCanColours = Console.ReadLine();
        Console.WriteLine("You have selected the following colour: " + selectedPaintCanColours.ToLower());


        if (selectedPaintCanColours.ToLower() == "red")
        {
            Console.WriteLine("Your total is £" + red);
        }
        else if (selectedPaintCanColours.ToLower() == "blue")
        {
            Console.WriteLine("Your total is £" + blue);
        }
        else if (selectedPaintCanColours.ToLower() == "yellow")
        {
            Console.WriteLine("Your total is £" + yellow);
        }
        else if (selectedPaintCanColours.ToLower() == "green")
        {
            Console.WriteLine("Your total is £" + green);
        }
        else if (selectedPaintCanColours.ToLower() == "pink")
        {
            Console.WriteLine("Your total is £" + pink);
        }
        else if (selectedPaintCanColours.ToLower() == "violet")
        {
            Console.WriteLine("Your total is £" + violet);
        }
        else if (selectedPaintCanColours.ToLower() == "indigo")
        {
            Console.WriteLine("Your total is £" + indigo);
        }
        /*else (selectedPaintCanColours == ""){ 
            Console.WriteLine("Please start again");
        }*/

        //int totalPaintCans = Convert.ToInt32(Console.ReadLine());






        //Console.WriteLine("Your total comes to £" + totalPaintCans*);*/

    }

}
