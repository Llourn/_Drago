using UnityEngine;

public class FireCommand : IDragonCommand
{
    public string commandName = "fire";

    public void Execute()
    {
    }

    public string CommandName()
    {
        return commandName;
    }
}
