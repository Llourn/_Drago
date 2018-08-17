using UnityEngine;

public class FlinchingState : IDragonState
{
    public IDragonState HandleInput(DragonController dragon, IHandleInput input)
    {
        Debug.Log("Flinchstate Active");
        if(dragon.isFlinching) return null;

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
        Debug.Log("FLINCH STATE ENTERED");
        dragon.PlayFlinchAnimation();
    }
}
