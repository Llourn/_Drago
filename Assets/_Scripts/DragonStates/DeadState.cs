using UnityEngine;

public class DeadState : IDragonState
{
    public IDragonState HandleInput(DragonController dragonController, IHandleInput input)
    {
        return null;
    }

    public void Enter(DragonController dragon)
    {
        // TODO - Create death particle system?
        // Game over UI?
    }
}
