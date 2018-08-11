using UnityEngine;

public class PlayerInput : MonoBehaviour, IHandleInput
{

    IDragonCommand buttonX;
    IDragonCommand buttonA;
    IDragonCommand buttonB;

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

    public IDragonCommand Action()
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
