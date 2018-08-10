using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    Input input;

    IPlayerState state;

    PlayerInput playerInput;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        this.transform.Translate((playerInput.Move() * moveSpeed) * Time.deltaTime);
        IPlayerCommand currentCommand = playerInput.Action();
    }

    void HandleInput()
    {
        IPlayerState _state = state.HandleInput(this, input);
        if(_state != null)
        {
            state = _state;
        }
    }

}
