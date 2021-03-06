﻿using UnityEngine;

public class FiringState : IDragonState
{
    public IDragonState HandleInput(DragonController dragon, IHandleInput input)
    {
        if(dragon.isFlinching) return new FlinchingState();

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
        dragon.PlayFireAnimation();
    }
}
