using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex1
{
    class Program
    {
        //I creatd this method with the inputs amount and fromCurrency. I use them later to use as controls in the user input.
        static double ConvertToUSD(double amount, string fromCurrency)
        {

            //I used a switch case to handle exceptions input from the user
            switch (fromCurrency)
            {
                //This line allows you to convert EUR to USD
                case "EUR":

                    //This is the conversion rate from  EUR to USD
                    amount = (amount / .96);

                    //break from line
                    break;

                //This line allows you to convert JPY to USD
                case "JPY":

                    //This is the conversion rate from JPY to USD
                    amount = (amount * 152.2);
                    break;

                //Default used as error backup.
                default:

                    //Prints out if "EUR" or "JPY" are not typed
                    Console.WriteLine("Please enter a valid case");

                    //Returns invalid value for error
                    return -1;

            }

            //Returns the amount at the end to catch value created from equation
            return amount;



        }

        //Method for converting USD and JPY to EUR
        static double ConvertToEUR(double amount, string fromCurrency)
        {

            //Switch case to handle the choice
            switch (fromCurrency)
            {

                //USD converted to EUR
                case "USD":

                    //Formula for converting USD to EUR
                    amount = (amount * .96);
                    break;

                //JPY converted to EUR
                case "JPY":

                    //Formula for  converting JPY to EUR
                    amount = (amount * 158.18);

                    //breaks code
                    break;

                //Default used for errors
                default:

                    //Prints out statement indicating input error
                    Console.WriteLine("Please enter a valid case");

                    //returns invalid value for error
                    return -1;

            }

            //returns value retrieved from the equation
            return amount;

        }

        //Method for converting USD and EUR to JPY
        static double ConvertToJPY(double amount, string fromCurrency)
        {

            //Switch statement for value control
            switch (fromCurrency)
            {
                //Indicates conversion of USD to JPY
                case "USD":

                    //Assigns the amount integer the new value of the equation
                    amount = (amount / 152.20);

                    //breaks code
                    break;

                //Indicates conversion of EUR to JPY
                case "EUR":

                    //Assigns amount new value for conversion
                    amount = (amount / 158.18);

                    //breaks code
                    break;

                //Default case for errors
                default:

                    //Outputs error code
                    Console.WriteLine("Please enter a valid case");

                    //Returns invalid input for error
                    return -1;

            }

            //Stores the new value of amount for use later
            return amount;

        }

        static void Main(string[] args)
        {
            //assigned amount value for use later
            double amount = 0;

            //Assigned InitialCurrency a value to select which currency to start conversion from
            int initialCurrency = 0;

            //Assigned Currency a blank string for later use
            string currencySelect = "";

            //Outputs a line to indicate purpose of program
            Console.WriteLine("This program will convert your value input into a different currency.");

            //Prompts user to input amount used in conversion
            Console.WriteLine("Enter the amount to be converted");

            //assigns amount the user input value
            amount = Convert.ToInt32(Console.ReadLine());

            //Prompts user to select which value the input amount was
            Console.WriteLine("Which currency would you like to convert?");

            //Indicates USD
            Console.WriteLine("1. USD");

            //Indicates EUR
            Console.WriteLine("2. EUR");


            //Indicates JPY
            Console.WriteLine("3. JPY");


            //Converts user input to int for use in switch case
            initialCurrency = Convert.ToInt32(Console.ReadLine());



            //I seperated the users choice into seperate switch cases using variables to automate the conversion process
            switch (initialCurrency)
            {
                //case 1, for USD
                case 1:

                    //Prompts user to select which conversion, using strings
                    Console.WriteLine("Which currency would you like to convert to?");

                    //Indicates EUR
                    Console.WriteLine("EUR");

                    //Indicates JPY
                    Console.WriteLine("JPY");

                    try 
                    {
                        //Allows user to input a string to select which conversion to use
                        currencySelect = Console.ReadLine();

                        //nested switch statement to use for selected currency
                        switch (currencySelect)
                        {
                            //indicates EUR conversion
                            case "EUR":

                                //Assigns amount to the value returned from ConvertToUSD
                                amount = ConvertToUSD(amount, "EUR");

                                //Prompts the return value with a string statement for users to understand clearly
                                Console.WriteLine("Your amount is " + amount + " in EUR.");

                                //breaks code
                                break;

                            //Indicates JPY conversion
                            case "JPY":

                                //Calls ConvertToUSD method with the values of amount, using the switch case variable JPY
                                amount = ConvertToUSD(amount, fromCurrency: "JPY");

                                //Indicates the amount for user ease
                                Console.WriteLine("Your amount is " + amount + " in JPY.");

                                //breaks code
                                break;
                        }
                    }
                    catch (Exception e) { Console.WriteLine("Please enter a valid input"); }
                    //breaks code
                    break;

                //Case 2 for ConvertToEUR
                case 2:

                    //Prompts user to select which currency to convert to
                    Console.WriteLine("Which currency would you like to convert to?");

                    //Prompt for USD
                    Console.WriteLine("USD");

                    //Prompts for JPY
                    Console.WriteLine("JPY");

                    //Assigns user currencySelect for value selected
                    currencySelect = Console.ReadLine();

                    //Switch case to choose conversion
                    switch (currencySelect)
                    {
                        //Case for USD conversion
                        case "USD":

                            //assigns amount the value returned from the converttoEUR method
                            amount = ConvertToEUR(amount, "USD");

                            //writes out amount value and sentence for user comfort
                            Console.WriteLine("Your amount is " + amount + " in USD.");
                            break;

                        //Case for JPY conversion
                        case "JPY":

                            //Assigns amount the value returned from the ConvertToEUR equation for JPY conversion
                            amount = ConvertToEUR(amount, "JPY");

                            //Writes out amount value with sentence
                            Console.WriteLine("Your amount is " + amount + " in JPY.");
                            break;
                    }
                    //breaks code
                    break;
                //Case for JPY conversion
                case 3:

                    //Prompts user to select conversion
                    Console.WriteLine("Which currency would you like to convert to?");

                    //Indicates conversion to USD
                    Console.WriteLine("USD");

                    //Indicates conversion to EUR
                    Console.WriteLine("EUR");

                    //Allows user to input which conversion to choose
                    currencySelect = Console.ReadLine();

                    //Switch case for currency conversion
                    switch (currencySelect)
                    {

                        //Case for JPY to USD Conversion
                        case "USD":

                            //Assigns amount value from ConvertToJPY equation
                            amount = ConvertToJPY(amount, "USD");

                            //Displays amount retrieved from ConvertToJPY
                            Console.WriteLine("Your amount is " + amount + " in USD.");

                            //breaks code
                            break;

                        //Case for JPY to EUR Conversion
                        case "EUR":

                            //Assigns amount the value retrieved from the conversion process
                            amount = ConvertToJPY(amount, "EUR");

                            //Writes out retrieved value with sentence
                            Console.WriteLine("Your amount is " + amount + " in EUR.");
                            break;
                    }
                    break;

                //Default case for errors
                default:
                    Console.WriteLine("Please enter a valid input");
                    break;


            }
            //allows console to stay open after for users
            Console.Read();


        }
    }
}