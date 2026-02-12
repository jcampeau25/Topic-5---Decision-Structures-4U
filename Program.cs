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

            double cost, hoursParked;
            int minutes;

            minutes = 0;


            Console.WriteLine("Please enter the number of minutes your car was parked");

            while (!Int32.TryParse(Console.ReadLine(), out minutes) || minutes <= 1)
            {
                Console.WriteLine("Invalid Input. Please enter a whole number that is greater than 0");
            }



            hoursParked = (minutes / 60);
            hoursParked = Math.Ceiling(hoursParked);

            Console.WriteLine(hoursParked);

            cost = (2 * (hoursParked - 1)) + 4;

            if (cost >= 20)
            {
                cost = 20;
            }

            Console.WriteLine(cost);


        }
    }
}
