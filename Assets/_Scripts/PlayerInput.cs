using UnityEngine;

public class PlayerInput : MonoBehaviour {

    IPlayerCommand buttonX;
    IPlayerCommand buttonA;
    IPlayerCommand buttonB;

    private void Start()
    {
        buttonX = new DeflectingCommand();
        buttonB = new DashCommand();
        buttonA = new FireCommand();
    }

    public Vector3 Move()
    {
        return new Vector3(Input.GetAxis("Horizontal"),0.0f, Input.GetAxis("Vertical"));
    }

    public IPlayerCommand Action()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            buttonA.Execute();
            return buttonA;
        }
        else if(Input.GetButtonDown("Fire2"))
        {
            buttonB.Execute();
            return buttonB;
        }
        else if(Input.GetButtonDown("Fire3"))
        {
            buttonX.Execute();
            return buttonX;
        }
        else
        {
            return null;
        }
        
    }

}
