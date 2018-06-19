using System;

namespace beginnerApp
{
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
}