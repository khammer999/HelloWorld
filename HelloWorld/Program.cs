using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
       static void Main(string[] args){

            //Part one greeting statements
            string messageOne = "Hello World!";
            string messageTwo = "I am Spartacus";

            // part two Set initial Spartacus atributes
            int ageOne=35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.1234578f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            //Part three display varible values
            Console.WriteLine(messageOne); //display intial greeting to console
            Console.WriteLine(messageTwo);

            //part four mathematical operator,bool and char examples
            Console.WriteLine(ageOne + ageTwo);//addition example
            Console.WriteLine(heightOne - heightTwo);//subtration example
            Console.WriteLine(weightOne * weightTwo);//multiply example
            Console.WriteLine(isGodLikeOne);//boll example
            Console.WriteLine(genderMale);// Char example

            //part five variable re-assignment
             ageTwo = 70;
             heightTwo = 35.12345f;
             weightTwo = -429.1234573f;

            //part six mathimatical operator examples
            Console.WriteLine(ageOne + ageTwo);
            Console.WriteLine(heightOne - heightTwo);
            Console.WriteLine(weightOne * weightTwo);
            Console.WriteLine(ageTwo / ageOne);
            Console.WriteLine(ageTwo % ageOne);
            Console.WriteLine(ageThree / ageOne);
            Console.WriteLine(ageThree % ageOne);
            
            //part seven increment and decrement operator examples
            ageTwo = ageTwo + 1;
            Console.WriteLine(ageTwo);
            ageTwo++;
            Console.WriteLine(ageTwo);
            ageTwo--;
            Console.WriteLine(ageTwo);

            // part eight concantenation example
            Console.WriteLine(messageOne+" "+messageTwo);

            Console.WriteLine("I am "+""+ageOne+""+" years old, and it is "+isGodLikeOne+" that I am godlike...");
            Console.WriteLine("I weigh around "+ weightOne +" pounds and i am around " + heightOne + " inches tall...");
            Console.WriteLine("My father is {0} years old, an it is {1} that he is a god.", ageThree, isGodLikeOne);

            Console.WriteLine("I am {0} years old, and it is {1} that i am godlike.", ageOne, isGodLikeOne);
            Console.WriteLine("I weigh around {0} pounds , and I am around {1} inches tall...", weightOne, heightOne);


            //part nine string equality examples
            Console.WriteLine(messageTwo.Equals(messageOne));
            Console.WriteLine(messageTwo.Equals("I am Spartacus"));
            /*
             //part ten string length examples
             int messOneLength = messageOne.Length;
             int messTwoLength = messageTwo.Length;

             Console.WriteLine("the lenghth of messageOne is " + messageOne.Length);
             Console.WriteLine("the lenghth of messageTwo is " + messageTwo.Length);
             Console.WriteLine("the lenghth of messageOne is " + messOneLength);

             Console.Write("this is the first line.\n second line "); */

            //part eleven conditional examples

            /*  string cityOne = "Vesuvius";
              string cityTwo = "Nola";
              string cityThree = "Nucera";
              int cityOneDistance, cityTwoDistance, cityThreeDistance;

              //solicit user input
              Console.WriteLine("what is the distance to {0}?", cityOne);
              cityOneDistance = int.Parse(Console.ReadLine());
              Console.WriteLine("what is the distance to "+ cityTwo +"?");
              cityTwoDistance = int.Parse(Console.ReadLine());
              Console.WriteLine("what is the distance to " + cityThree + "?");
              cityThreeDistance = int.Parse(Console.ReadLine());

              if ((cityOneDistance <= 125) && ((cityOneDistance < cityTwoDistance) && (cityOneDistance < cityThreeDistance)))
              {
                  Console.WriteLine("we will march to {0}", cityOne);
              }
              if (( cityTwoDistance <= 125) && ((cityTwoDistance < cityOneDistance) && (cityTwoDistance < cityThreeDistance)))
              {
                  Console.WriteLine("we will march to "+ cityTwo);
              }
              if ((cityThreeDistance <= 125) && ((cityThreeDistance < cityOneDistance) && (cityThreeDistance < cityTwoDistance)))
              {
                  Console.WriteLine("we will march to " + cityThree);
              } */

             Console.WriteLine("What is your rank?");
             string rank = Console.ReadLine();

             Console.WriteLine("What is your age?");
             int age = int.Parse(Console.ReadLine());

             if ((rank == "officer") || (age <= 26))
             {
                 Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
             }
             else
             {
                 Console.WriteLine("Sorry, you are staying home.");
             } 

            Console.WriteLine("What is your rank soldier?");
            string rank = Console.ReadLine().ToLower();

            Console.WriteLine("What is your age soldier?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your job soldier?");
            string job = Console.ReadLine().ToLower();

            if ((rank == "officer") || (age <= 26))
            {
                Console.WriteLine("Get your gear, kiss your family goodbye,put on your marching boots.");
            }
            else if ((job == "cook") && (age >= 26))
            {
                Console.WriteLine("My army has to eat. Pack your pots and pans.");
            }
            else
            {
                Console.WriteLine("Sorry, you are staying home.");
            } 

            switch (job)
            {
                case "infantry":
                    Console.WriteLine("You will carry a sword.");
                    break;

                case "archer":
                    Console.WriteLine("You will carry a bow and arrow.");
                    break;

                case "supply":
                    Console.WriteLine("You will carry pots and pans.");
                    break;

                case "specialist":
                    Console.WriteLine("You will operate the catapult.");
                    break;

                default:
                    Console.WriteLine("You will ride horseback.");
                    break;
            }  









            //end of program DONT WRITE BEYOND HERE



        }
    }
}
