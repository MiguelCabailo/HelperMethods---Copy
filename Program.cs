using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld.print("Hello world");

            Console.WriteLine("The Name Game");
  
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            */

            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);

            //first used the value returned from the method
            //the second and third used the stored variable as a result of the method
            DisplayResult(ReverseString(firstName), 
                reversedLastName,
                reversedCity);

            //this version only accepts one so we concactinate if we want all displayed
            DisplayResult(reversedFirstName + " " + 
                reversedLastName + " " + 
                reversedCity);
            DisplayResult(reversedFirstName);
            DisplayResult(reversedFirstName + " " + "Hello World");
            Console.ReadLine();
        }

        //we want this to accept an input string and return the result to the caller
        //needs to return something back to the caller
            //use the return keyword
            //when this code is executed, it accepts a string message to reverse
                //then it returns the string message backwards and allows it to be stored in a new string variable.
        private static string ReverseString(string message)
        {
            //string message = "Hello World";
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            //this can be returned and stored in a variable
            return String.Concat(messageArray);
        }

        private static void DisplayResult(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCity)
        {
            Console.Write("Results: ");
            Console.WriteLine(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }

        private static void DisplayResult(
            string message)
        {
            Console.Write("Results: ");
            Console.WriteLine(String.Format(message));
        }

    }

    public class HelloWorld
    {
        public static void print(string anyString)
        {
            Console.Write(anyString);

        }
    }
}
