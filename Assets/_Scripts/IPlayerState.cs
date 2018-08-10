using UnityEngine;

public interface IPlayerState
{
    IPlayerState HandleInput(PlayerController playerController, Input input);

    void Update();
}
