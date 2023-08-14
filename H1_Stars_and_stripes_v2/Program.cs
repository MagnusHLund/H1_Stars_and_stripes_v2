namespace H1_Stars_and_stripes_v2
{
    internal class Program
    {
        // Array to keep track of each lengths and heights
        static int[] cordinates = new int[] {
            23, // Length of blue area
            11, // Height of blue area
            15, // Length of red or white area, with blue on the same line
            38, // Total length of flag
            26 // Total height of flag
        };

        static void Main()
        {
            // Creates an int and bool, to handle white and red coloring
            bool isRed = false;
            int counter = 1;

            // Creates a bool to keep track of type 1 and type 2 stars
            bool Type1 = false;

            // For loop that runs each line on the Y axis
            for (int height = 0; height < cordinates[4]; height++)
            {
                // Changes color between red and white, based on the value of counter
                if (counter % 2 == 1)
                    isRed = !isRed;

                // Adds +1 to the counter
                counter++;

                // If the blue height is larger than the for loop index "height"
                if (height < cordinates[1])
                {
                    // Changes the background color to blue
                    Console.BackgroundColor = ConsoleColor.Blue;

                    // For loop to write the X axis of the blue area
                    for (int blueLength = 0; blueLength < cordinates[0]; blueLength++)
                    {

                        // If the height is 0 or or the blue height, minus 1, then write only spaces
                        if (height == 0 || height == cordinates[1] - 1)
                            Console.Write(" ");
                        else // Else write both spaces and stars,
                        {
                            // Checks if its type 1 or type 2 star layout
                            if (Type1)
                            {
                                if (blueLength % 4 == 1)
                                    Console.Write("*");
                                else
                                    Console.Write(" ");

                                Type1 = !Type1;
                            } 
                            else
                            {

                                if (blueLength % 4 == 3)
                                    Console.Write("*");
                                else
                                    Console.Write(" ");

                                Type1 = !Type1;
                            }
                        }
                    }

                    // For the remaining length, after blue area
                    for (int halfLength = 0; halfLength < cordinates[2]; halfLength++)
                    {
                        // decides if colors should be red or white
                        if (isRed)
                            Console.BackgroundColor = ConsoleColor.Red;
                        else
                            Console.BackgroundColor = ConsoleColor.White;

                        Console.Write(" ");
                    }
                }
                else // if the blue area has been finished
                {
                    // For the total length of the flag
                    for (int totalLength = 0; totalLength < cordinates[3]; totalLength++)
                    {
                        // Change color between red and white
                        if (isRed)
                            Console.BackgroundColor = ConsoleColor.Red;
                        else
                            Console.BackgroundColor = ConsoleColor.White;

                        Console.Write(" ");
                    }
                }

                // Goes to the next line
                Console.WriteLine();
            }
        }
    }
}