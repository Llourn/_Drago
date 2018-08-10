using UnityEngine;

public class FireCommand : IPlayerCommand
{
    public void Execute()
    {
        Debug.Log("FIRE!");
    }
}
