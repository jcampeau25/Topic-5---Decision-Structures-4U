namespace Topic_5___Decision_Structures_4U
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Part 1

            int angle;
            string direction = "error";

            Console.WriteLine("Please enter an angle (to the nearest full degree) and I will convert that angle to the most fiiting cardinal direction");
            Int32.TryParse(Console.ReadLine(), out angle);

            if (angle < 0)
            {
                angle = 360 + angle;
            }
            if (angle > 360)
            {
                angle = angle%360;
            }

            if (angle >= 315 || angle <= 45)
            {
                direction = "North";
            }

            if (angle > 45 && angle < 135 )
            {
                direction = "East";
            }

            if (angle >= 135 && angle <= 225)
            {
                direction = "South";
            }

            if (angle < 315 && angle > 225)
            {
                direction = "West";
            }

            
   
            Console.WriteLine();
            Console.WriteLine("The direction of that angle is " + direction);
            Console.WriteLine();

            // Part 2

            double cost, hoursParked, remainder;
            int minutes;

            minutes = 0;


            Console.WriteLine("Please enter the number of minutes your car was parked");

            while (!Int32.TryParse(Console.ReadLine(), out minutes) || minutes < 1)
            {
                Console.WriteLine("Invalid Input. Please enter a whole number that is greater than 0");
            }


           if (minutes % 60 > 0)
            {
                hoursParked = minutes / 60 + 1;
            }

            else
            {
                hoursParked = minutes / 60;
            }

    


            cost = (2 * (hoursParked - 1)) + 4;

            if (cost >= 20)
            {
                cost = 20;
            }



            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~RECEIPT~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine("NUMBER OF HOURS: " + hoursParked);
            Console.WriteLine();
            Console.WriteLine("Total Cost: " + cost);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for choosing Sam's Parking Garage");
            Console.WriteLine();
            Console.WriteLine();


            // Part 3

            int category;
            Console.WriteLine("Please enter a category of hurricane and I will tell you what wind speeds fall under that category");
            while (!int.TryParse(Console.ReadLine(), out category) || category < 1 || category > 5)
            {
                Console.WriteLine("Please enter a valid integral input from 1-5");
            }

            switch (category)
            {
                case 1:
                    Console.WriteLine("A catgory 1 hurricane contains wind speeds from 119-153 km/h or 74-95 mph or 64-82 kt");
                    break;

                case 2:
                    Console.WriteLine("A category 2 hurricane contains wind speeds from 154-177 km/h or 96-110 mph or 83-95 kt");
                    break;

                case 3:
                    Console.WriteLine("A category 3 hurricane contains wind speeds from 178-209 km/h or 111-130 mph or 96 - 113 kt");
                    break;

                case 4:
                    Console.WriteLine("A category 4 hurricane contains wind speeds from 210-249 km/h or 131-155 mph or 114-135 kt");
                    break;

                case 5:
                    Console.WriteLine("A category 5 hurricane contains wind speeds greater than 249 km/h or 155 mph or 135kt");
                    break;






            }


            

        }
    }
}
