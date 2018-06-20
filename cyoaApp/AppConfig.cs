using System;

namespace cyoaApp
{
    class AppConfig
    {
        protected string _username;
        protected bool _appRunning = true;

        public AppConfig(string username)
        {
            this._username = username;
        }

        public string getUsername()
        {
            return this._username;
        }

        public bool getAppRunning()
        {
            return this._appRunning;
        }

        public void endProgram()
        {
            Console.WriteLine("Ending Program.");
            this._appRunning = false;
        }
    }
    
}