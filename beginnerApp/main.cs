using System;

namespace beginnerApp
{
    class BeginningApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********\nBASIC CONSOLE APPLICATION\n***********\nPlease input your name:");
            Console.WriteLine("Name given: {0}", Console.ReadLine());
            AppConfig config = new AppConfig();
            string[] actions = config.getActions();
            while (config.getAppRunning()) {
                Console.WriteLine("Please select a choice");
                Console.WriteLine("0.) End program");
                for (int i = 0; i < actions.Length; i++) {
                    Console.WriteLine("{0}.) {1}", i+1, actions[i]);
                }
                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input);
                int choiceCheck;
                Console.WriteLine("Your choice: {0}", choice);
                if (!(int.TryParse(input, out choiceCheck)) || choice > actions.Length || choice < 0) {
                    Console.WriteLine("Invalid choice!!");
                    return;
                } else {
                    config.callFunction(choice);
                }
            }
        }


        public static void calcPiToNth()
        {
            Console.WriteLine("****Calculating Pi to the Nth degree****\nPlease enter a value, less no more than 15, for n:");
            string input = Console.ReadLine();
            int n;
            if (!(int.TryParse(input, out n)) || n > 15 || n < 0) {
                Console.WriteLine("ERROR: Input must be a positive integer no more than 15. Exiting Calc pi to nth degree...");
                return;
            }
            Console.WriteLine(Math.Round(Math.PI, n));
        }

        public static void reverseString()
        {
            Console.WriteLine("****Reverse a string****\nPlease enter a string to reverse:");
            string input = Console.ReadLine();
            char[] characterArray = input.ToCharArray();
            string newString = "";
            for (int i = characterArray.Length-1; i >= 0; i--) {
                newString += characterArray[i];
            }
            Console.WriteLine(newString);
        }

        public static void detectPalindrome()
        {
            Console.WriteLine("****Reverse a string****\nPlease enter a string to detect whether it is a palindrome or not:");
            string input = Console.ReadLine();
            char[] characterArray = input.ToCharArray();
            int left = 0;
            int right = characterArray.Length-1;
            while (left <= right) {
                if (characterArray[left++] != characterArray[right--]) {
                    Console.WriteLine("{0} is NOT a palindrome", input);
                    return;
                }
            }
            Console.WriteLine("{0} is indeed a palindrome", input);
        }

        public static void sortNumberList()
        {
            Console.WriteLine("****Sort a list of Numbers****");
            string input = "0";
            int[] inputArray = new int[20];
            int i = 0;
            int output;
            while (input != "s" && i < 20) {
                Console.WriteLine("Please input a number. Enter 's' to stop entering numbers.");
                input = Console.ReadKey().KeyChar.ToString();
                if (!(int.TryParse(input, out output)) && input != "s") {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                } else {
                    inputArray[i++] = output;
                    Console.WriteLine("\nNumber added");
                }
            }
            //TODO add sorting here
        }

        // Fibbonacci number is the sum of the two preceding numbers
        public static void calcFibbonacciToNth()
        {
            Console.WriteLine("****Calculate Fibbonacci Sequence to the Nth Degree****\nPlease enter a value for n:");
            string input = Console.ReadLine();
            int n;
            int result;
            if (!(int.TryParse(input, out n)) || n < 0) {
                Console.WriteLine("ERROR: Input must be a non-negative integer. Exiting Calc pi to nth degree...");
                return;
            } else if (n == 0) {
                result = 0;
            } else {
                result = calcFibbonacci(n, 1, 0);
            }
            Console.WriteLine("Result: Fibbonacci Sequence to {0} degree is: {1}", n, result);
        }

        public static int calcFibbonacci(int n, int oneNumPrevious, int twoPrevious)
        {
            if (n == 1) {
                return oneNumPrevious;
            } else {
                return calcFibbonacci(
                    (n - 1),
                    (oneNumPrevious + twoPrevious),
                    oneNumPrevious
                );
            }
        }

        public static void imperialMetricWeightConversion()
        {
            Console.WriteLine("****Imperial/Metric Weight Conversion****\nPlease enter 'lbs' to convert pounds to kilograms or"+
            "'kg' to convert kilograms to pounds:");
            string input = Console.ReadLine();
            double n;
            double result;
            if (input == "lbs") {
                //convert pounds to kg
                Console.WriteLine("Pounds selected.\nPlease enter the number of pounds to convert to kilograms:");
                input = Console.ReadLine();
                if (!(double.TryParse(input, out n))) {
                    Console.WriteLine("ERROR: Input must be a number. Exiting imperial/metric weight coversion...");
                    return;
                } else {
                    result = n * 0.4535924;
                    Console.WriteLine("Result: {0} pounds = {1} kilograms.", n, result);
                }
            } else if (input == "kg") {
                //convert kg to pounds
                Console.WriteLine("Kilograms selected.\nPlease enter the number of kilograms to convert to pounds:");
                input = Console.ReadLine();
                if (!(double.TryParse(input, out n))) {
                    Console.WriteLine("ERROR: Input must be a number. Exiting imperial/metric weight coversion...");
                    return;
                } else {
                    result = n * 2.204623;
                    Console.WriteLine("Result: {0} kilograms = {1} pounds.", n, result);
                }
            } else {
                //invalid input
                Console.WriteLine("ERROR: Input must be either lbs or kg. Exiting imperial metric weight conversion...");
                return;
            }
        }

        public static void arraysToJsonString()
        {
            Console.WriteLine("****Arrays of Strings to JSON string****");
            //init values
            int arrayLen = 30;
            char [] keyArray = new char [arrayLen];
            char [] valueArray = new char [arrayLen];
            string itsyBitsy = 
                "TheitsybitsyspiderClimbedupthewaterspoutDowncametherainAndwashedthespideroutOutcamethesunAnddriedupalltherainAndtheitsy-bitsyspiderClimbedupthespoutagain";
            char [] itsyBitsyChar = itsyBitsy.ToCharArray();

            //put char values into key and value arrays
            int x = 0;
            for (int i = 0; i < arrayLen; i++) {
                keyArray[i] = itsyBitsyChar[x++];
                valueArray[i] = itsyBitsyChar[x++];
            }
            
            //loop through values and populate strong to be json

            string jsonString = "{";
            for (int i = 0; i < arrayLen; i++) {
                Console.WriteLine("{0} => {1}", keyArray[i], valueArray[i]);
                jsonString += keyArray[i] + ":" + valueArray[i];
                if (i+1 != arrayLen) {
                    jsonString += ",";
                }
            }
            jsonString += "}";

            //done
            Console.WriteLine("JSON STRING: {0}", jsonString);
        }
    }
}