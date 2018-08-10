using UnityEngine;

public class DashCommand : IPlayerCommand
{
    public void Execute()
    {
        Debug.Log("DASH!");
    }

}
