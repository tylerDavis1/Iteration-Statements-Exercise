using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void main(string[] args)
        {
            


        }
            
            public static void PrintThousand()
            {
                for (int i = 1000; i >= -1000; i--)
                {
                    Console.WriteLine(i);
                    
                }
            } 
                

            
        

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        public static bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 != num2)
            {
                return false; 
            }else
            {
                return true;
            }
        }


        
        
        //Write a method to check whether a given number is even or odd
       
        public static void EvenOrOdd(int number)
        {
        
        if (number % 2 == 0)
        {
            Console.WriteLine($"Aye that's even");
        }
        else
        {
            Console.WriteLine($"definitely odd");
        }
    }

        
//Write a method to check whether a given number is positive or negative
           public static bool IsPositive(int num1)
        {
            if(num1 > 0)
            {
                return true;
            }
            return false;

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Yes indeed come and vote.");
                return true;
            }
            else
            {
                Console.WriteLine($"sorry youngster you're to young.");
                return false;
            }

        } 
        
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsTenRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;
            }
            return false;
            
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultipliUpToTwelve()
        {
            for (int i = 1; i <= 12; i *= 2)
            {
                Console.WriteLine(i);
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
            UpByThrees();
            AreTwoNumbersTheSame(2, 2 );
            EvenOrOdd(7);
            IsTenRange(5);
            IsPositive(7);
            OfVotingAge(78);
            MultipliUpToTwelve();

            


        }
    }
}
