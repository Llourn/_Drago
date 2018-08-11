using UnityEngine;

public class DeflectingCommand : IDragonCommand
{
    public string commandName = "deflect";

    public void Execute()
    {
        Debug.Log("DEFLECT!");
    }
    
    public string CommandName()
    {
        return commandName;
    }
}
