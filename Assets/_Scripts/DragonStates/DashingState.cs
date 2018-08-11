using UnityEngine;

public class DashingState : IDragonState
{
    public IDragonState HandleInput(DragonController dragonController, IHandleInput input)
    {
        if(input.Move() == Vector3.zero)
        {
            return new IdlingState();
        }
        else if(input.Move() != Vector3.zero)
        {
            return new RunningState();
        }
        else
        {
            return null;
        }
    }

    public void Enter(DragonController dragon)
    {
        //TODO - Create Dash animation.
    }
}
