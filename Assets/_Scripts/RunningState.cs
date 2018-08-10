using UnityEngine;

public class RunningState : IPlayerState
{

    public IPlayerState HandleInput(PlayerController playerController, Input input)
    {
        //if input.x && input.y == 0
        //Change to standing state
        //

        return new RunningState();
    }

    public void Update()
    {

    }
}
