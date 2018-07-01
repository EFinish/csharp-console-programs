using System;
using adventure1;

namespace cyoaApp
{
    class CyoaApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********\nCHOOSE YOUR OWN ADVENTURE APPLICATION\n***********\nPlease input your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Name given: {0}", name);
            AppConfig config = new AppConfig(name);
            string[] actions = config.getActions();
            while (config.getAppRunning()) {
                Console.WriteLine("Please select an adventure");
                Console.WriteLine("0.) End program\n1.)Adventure 1");
                // for (int i = 0; i < actions.Length; i++) {
                //     Console.WriteLine("{0}.) {1}", i+1, actions[i]);
                // }
                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input);
                int choiceCheck;
                Console.WriteLine("Your choice: {0}", choice);
                if (!(int.TryParse(input, out choiceCheck)) || choice > actions.Length || choice < 0) {
                    Console.WriteLine("Invalid choice!!");
                    return;
                } else {
                    switch(choice){
                        case 0:
                            config.endProgram();
                            break;
                        case 1:
                            
                    }
                }
            }
        }
    }
}