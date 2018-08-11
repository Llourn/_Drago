using UnityEngine;

public class FireCommand : IDragonCommand
{
    public string commandName = "fire";

    public void Execute()
    {
        Debug.Log("FIRE!");
    }

    public string CommandName()
    {
        return commandName;
    }
}
