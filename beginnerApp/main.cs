using System;

class BeginningApp
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please input your name:");
        Console.WriteLine("Name given: {0}", Console.ReadLine());
        Actions action = new Actions();
        string[] actions = action.getActions();
        bool appRunning = true;
        while (appRunning) {
            Console.WriteLine("Please select a choice");
            for (int i = 0; i < actions.Length; i++) {
                Console.WriteLine("{0}.) {1}", i, actions[i]);
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your choice: {0}", choice);
            switch(choice) {
                case 0:
                    Console.WriteLine("Ending Program.");
                    appRunning = false;
                    break;
                case 1:
                    calcPiToNth();
                    break;
                case 2:
                    reverseString();
                    break;
                case 3:
                    detectPalindrome();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void calcPiToNth()
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

    static void reverseString()
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

    static void detectPalindrome()
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
}

class Actions
{
    //always try to use string instead of String
    public string[] _actions = {
        "Exit App",
        "Calculate Pi to the Nth degree",
        "Reverse a string",
        "Detirmine a palindrome"
    };

    public string[] getActions()
    {
        return _actions;
    }

    public bool checkIfValidAction(int choice) {
        return choice < _actions.Length;
    }
}