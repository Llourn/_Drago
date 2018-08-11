using UnityEngine;

public interface IDragonState
{
    IDragonState HandleInput(DragonController dragonController, IHandleInput input);
    void Enter(DragonController dragonController);
}
