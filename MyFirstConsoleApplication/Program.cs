using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber;
            bool isMyNameMason;

            string name = null;

            name?.ToString();

            //read input from a user
            Console.WriteLine("What is your first name");
            var input = Console.ReadLine();

            //strings
            name = "Nathan";
            char firstLetter = 'N';

            //let myInterpolatedString =  `this stuff ${firstLetter}`;
            var myInterpolatedString = $"My name is {input} and the " +
                                       $"first letter of my name is {firstLetter}";

            var stringLiteral = @"This is a paragraph.
                                  It is across multiple lines.
                                  Returns will be honored in the output.";
            
            Console.WriteLine(myInterpolatedString);
            Console.WriteLine(stringLiteral);

            //Number types
            int number = Int32.MaxValue;

            long bigNumber = Int64.MaxValue;

            short littleNumber = Int16.MaxValue;

            Console.WriteLine(number);
            Console.WriteLine(bigNumber);
            Console.WriteLine(littleNumber);

            //decimals can be represented by [f]loat(32bit) [d]ouble(64bit) or deci[m]al(128bit) 
            var adding = 1 + 1.1d;
            var division = 3 / 2d;


            var implicitStringThing = "this is an implicitly typed variable.";
            
            int uninitializedInt;
            var otherThing = "";

            var today = DateTime.Today;
            
            //instantiation
            var bestYear = new DateTime(2020,1,1);

            //anonymous type, new object
            var person = new {Name = "Nathan"};

            //everything either is or can be an object
            object weirdStuff = 1234;
            weirdStuff = "More craziness";

            Console.WriteLine(weirdStuff);

            var names = new string[5];

            var secondName = names[1];
            names[1] = "Jimmy";

            var colors = new string[] {"white", "blue", "black", "yellow", "teal", "magenta"};


            if (input == "Nathan")
            {
                Console.WriteLine("Duh");
            }
            else if (input == "blerg")
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("Not Nathan");
            }

            for (var i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"currently for looping on color {colors[i]}");
            }

            var counter = 1;
            while (true)
            {
                Console.WriteLine($"While loop iteration {counter}.");

                if (counter <= 5)
                {
                    counter++;
                    continue;
                }

                break;
            }

            foreach (var color in colors)
            {
                Console.WriteLine($"Foreach looping on color {color}");
            }


        }
    }
}
