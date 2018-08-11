using UnityEngine;

public class DeflectingState : IDragonState
{
    public IDragonState HandleInput(DragonController dragon, IHandleInput input)
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
        dragon.PlayDeflectAnimation();
    }
}
