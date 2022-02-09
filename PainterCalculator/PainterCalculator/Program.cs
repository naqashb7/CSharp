using System;

namespace Calculator;

class Calculator
{

    static void Main(string[] args)

    {
        Console.WriteLine("Are you painting walls? (Yes or No) ");
        string walls = Console.ReadLine();
        Console.WriteLine("Are you painting doors? (Yes or No) ");
        string doors = Console.ReadLine();  
        Console.WriteLine("Are you painting windows? (Yes or No) ");
        string windows = Console.ReadLine();
        Console.WriteLine("Are you painting ceilings? (Yes or No) ");
        string ceilings = Console.ReadLine();   



        //total up wall area
        if (walls.ToLower() != "no")
        {
            Console.WriteLine("How many walls will you be painting?");
            int totalwalls = Convert.ToInt32(Console.ReadLine());
            if (totalwalls > 1)
            {
                Console.WriteLine("Are all the walls the same size? (Yes or No) ");
                string wallSizeSame = Console.ReadLine();
                if (wallSizeSame.ToLower() != "yes")
                {
                    Console.WriteLine("Please enter the details for each wall starting with the height and width of the first wall and then the same for consequent walls");

                    double wallsarea = 0;
                    for(int i = 0; i <totalwalls; i++)
                    {
                        Console.WriteLine("What is the height of the area you will be painting in metres? (please enter a number)");
                        double wallsheight = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the width of the area you will be painting in metres? (please enter a number");
                        double wallswidth = Convert.ToDouble(Console.ReadLine());
                       
                        wallsarea = wallsheight * wallswidth;
                        Console.WriteLine("The total area for which you will need paint is " + wallsarea + "m^2");
                    }
                }
                else
                {
                    Console.WriteLine("What is the height of the area you will be painting in metres? (please enter a number)");
                    double wallsheight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is the width of the area you will be painting in metres? (please enter a number");
                    double wallswidth = Convert.ToDouble(Console.ReadLine());

                    double wallsarea = wallsheight * wallswidth * totalwalls;

                    Console.WriteLine("The total area you will be painting is " + wallsarea + "m^2");
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

        

        //total up door area 

        if (doors.ToLower() != "no")
        {
            Console.WriteLine("How many doors will you be painting?");
            int totaldoors = Convert.ToInt32(Console.ReadLine());
            if (totaldoors > 1)
            {
                Console.WriteLine("Are all the doors the same size? (Yes or No) ");
                string doorSizeSame = Console.ReadLine();
                if (doorSizeSame.ToLower() != "yes")
                {
                    double doorsarea = 0;
                    for (int i = 0; i < totaldoors; i++)
                    {
                        Console.WriteLine("What is the height of the area you will be painting in metres? (please enter a number)");
                        double doorsheight = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the width of the area you will be painting in metres? (please enter a number");
                        double doorswidth = Convert.ToDouble(Console.ReadLine());

                        doorsarea = doorsheight * doorswidth;
                        Console.WriteLine("The total area for which you will need paint is " + doorsarea + "m^2");
                    }

                }
                else
                {
                    Console.WriteLine("What is the height of the area you will be painting in metres? (please enter a number)");
                    double doorsheight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is the width of the area you will be painting in metres? (please enter a number");
                    double doorswidth = Convert.ToDouble(Console.ReadLine());

                    double doorsarea = doorsheight * doorswidth * totaldoors;

                    Console.WriteLine("The total area you will be painting is " + doorsarea + "m^2");
                }
            }
            else
            {
                Console.WriteLine("What is the height of the area you will be painting in metres? (please enter a number)");
                double doorsheight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the width of the area you will be painting in metres? (please enter a number");
                double doorswidth = Convert.ToDouble(Console.ReadLine());
            }
        }
        else
        {
            Console.WriteLine("You have entered that you will not be painting any walls");
        }


        //Total up window pane area (work out how much paint is needed to paint a window)
        if (windows.ToLower() != "no")
        {
            Console.WriteLine("How many windows will you be painting?");
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
        

        //Total up ceiling area to be painted
        
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







        //double totalPaintArea = totalCeilingPaintArea + totalWindowPaintArea + totalDoorPaintArea + totalWallPaintArea;

        //Console.WriteLine("The total area that needs to be painted is " + totalPaintArea + "m^2");
        // use switch statement for paint values!!!!!!

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




        // multiply paint value by paint cans by using area to figure out how much paint is needed




        //Console.WriteLine("Your total comes to £" + totalPaintCans*);*/

    }

}
