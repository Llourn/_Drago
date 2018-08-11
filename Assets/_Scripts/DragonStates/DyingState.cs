using UnityEngine;

public class DyingState : IDragonState
{

    public IDragonState HandleInput(DragonController dragonController, IHandleInput input)
    {
        return null;
    }

    public void Enter(DragonController dragon)
    {
        dragon.PlayDieAnimation();
    }

}
