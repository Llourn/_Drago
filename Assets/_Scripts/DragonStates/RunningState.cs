using UnityEngine;

public class RunningState : IDragonState
{

    public IDragonState HandleInput(DragonController dragon, IHandleInput input)
    {
        if(dragon.isFlinching) return new FlinchingState();
        
        if(dragon.executingAction) return null;

        if(input.Action() != null)
        {
            if(input.Action().CommandName().Equals("fire"))
            {
                return new FiringState();
            }
            else if(input.Action().CommandName().Equals("deflect"))
            {
                return new DeflectingState();
            }
            else if(input.Action().CommandName().Equals("dash"))
            {
                return new DashingState();
            }
        }
        
        if(input.Move() == Vector3.zero)
        {
            return new IdlingState();
        }
        else
        {
            return null;
        }
    }

    public void Enter(DragonController dragon)
    {
        dragon.PlayRunningAnimation();
    }
}
