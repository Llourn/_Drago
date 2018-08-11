using UnityEngine;

public class DashCommand : IDragonCommand
{
    public string commandName = "dash";

    public void Execute()
    {
        Debug.Log("DASH!");
    }

    public string CommandName()
    {
        return commandName;
    }
}
