namespace cyoaTools
{
    interface PlayerAction
    {
        //string to fully describe what the action does
        string _description{ get; set; }
        //shorter version of _description
        string _shortDescription{ get; set; }
        //key the initiates the player's action
        char _execKey{ get; set; }

        void executePlayerAction();
    } 
}