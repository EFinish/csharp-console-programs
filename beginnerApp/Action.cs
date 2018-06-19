namespace beginnerApp
    {
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
    }