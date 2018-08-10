using UnityEngine;

public class DeflectingCommand : IPlayerCommand
{
    public void Execute()
    {
        Debug.Log("DEFLECT!");
    }
}
