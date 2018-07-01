namespace cyoaTools
{
    abstract class PlayerState
    {
        //string to fully describe what state the player is in
        protected string _description;
        //shorter version of _description
        protected string _shortDescription;
        //key the initiates the player's action
        protected PlayerAction _action;

        public void executePlayerAction(){
            this._action.executePlayerAction();
        }
    } 
}