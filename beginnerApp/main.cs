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
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void calcPiToNth()
    {
        Console.WriteLine("****Calculating Pi to the Nth degree****\nPlease enter the value for n:");
    }
}

class Actions
{
    //always try to use string instead of String
    public string[] _actions = {
        "Exit App",
        "Calculate Pi to the Nth degree"
    };

    public string[] getActions()
    {
        return _actions;
    }

    public bool checkIfValidAction(int choice) {
        return choice < _actions.Length;
    }
}