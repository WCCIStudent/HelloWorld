using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part one greetings statement
            string messageOne = "Hello World!";
            string messageTwo = "I am Spartacus";

            //Part two set initial Spartacus attributes
            int ageOne  = 35;
            int ageTwo  = 45;
            int ageThree = 80;
            double heightOne  = 72.50;
            double heightTwo  = 91.45;
            float weightOne  = 210.0284606f;
            float weightTwo  = 331.12345678f;
            bool isGodLikeOne  = true;
            bool isGodLikeTwo  = false;
            char genderMale  = 'M';
            char genderFemale  = 'F';

            ////Part three display variable values
            //Console.WriteLine(messageOne);//Displays intial greeting to console
            //Console.WriteLine(messageTwo);

            ////Part four mathematical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo);//Addition example
            //Console.WriteLine(heightOne - heightTwo);//Subtraction example
            //Console.WriteLine(weightOne * weightTwo);//Mutiplication example 
            //Console.WriteLine(isGodLikeOne);//Bool example
            //Console.WriteLine(genderMale);//Char example


            ////Part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;

            ////Part six mathematical operator examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part seven increment and decrement operator examples
            //ageTwo = ageTwo + 1;
            //Console.WriteLine(ageTwo);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);

            //Part eight concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am " + ageOne + " years old, and yes it's " + isGodLikeOne + " I am godlike." );
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");
            //Console.WriteLine("My father is {0} years old, and yes it's {1} he is a god.", ageThree, isGodLikeOne);
            //Console.WriteLine("I am {0} years old, and yes it's {1} I am godlike,", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);

            //Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //Part ten string length examples
            int messOneLength = messageOne.Length;
            int messTwoLength = messageTwo.Length;

            Console.WriteLine("The length of messageOne is " + messageOne.Length);
            Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            Console.WriteLine("The length of messageOne is " + messOneLength);
            Console.WriteLine("The length of messageTwo is " + messTwoLength);
            



        }
    }
}
