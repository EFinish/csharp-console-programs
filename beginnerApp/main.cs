using System;

class BeginningApp
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please input your name:");
        Console.WriteLine("Name given: {0}", Console.ReadLine());
        AppConfig config = new AppConfig();
        string[] actions = config.getActions();
        while (config.getAppRunning()) {
            Console.WriteLine("Please select a choice");
            Console.WriteLine("0.) End program");
            for (int i = 1; i < actions.Length; i++) {
                Console.WriteLine("{0}.) {1}", i, actions[i]);
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
        
    }
}

class Action 
{
    public string _actionName;
    public delegate void _callBack();
    _callBack _functionName;

    public Action(string actionName, _callBack nameOfFunction)
    {
        this._actionName = actionName;
        this._functionName = nameOfFunction;
    }

    public string getActionName()
    {
        return this._actionName;
    }

    public void callFunction()
    {
        this._functionName();
    }


}

class AppConfig
{
    protected Action[] actions = new Action[] {
        new Action(
            "Calculate Pi to the Nth degree",
            BeginningApp.calcPiToNth
        ),
        new Action(
            "Reverse a string",
            BeginningApp.reverseString
        ),
        new Action(
            "Detirmine a palindrome",
            BeginningApp.detectPalindrome
        ),
        new Action(
            "Sort a list of numbers",
            BeginningApp.sortNumberList
        ),
        new Action(
            "Calculate Fibbonaci Sequence to Nth degree",
            BeginningApp.calcFibbonacciToNth
        ),
        new Action(
            "Imperial/Metric Weight Conversion",
            BeginningApp.imperialMetricWeightConversion
        )
    };

    protected bool appRunning = true; 

    public void endProgram()
    {
        Console.WriteLine("Ending Program.");
        this.appRunning = false;
    }

    public string[] getActions()
    {
        int numActions = this.actions.Length;
        string[] results = new string[numActions];
        for(int i = 0; i < numActions; i++) {
            results[i] = this.actions[i].getActionName();
        }
        return results;
    }

    public bool getAppRunning()
    {
        return this.appRunning;
    }

    public void callFunction(int i)
    {
        if (i == 0) {
            this.endProgram();
        } else {
            this.actions[i-1].callFunction();
        }
    }
}