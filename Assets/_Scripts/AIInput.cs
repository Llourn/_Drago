using UnityEngine;

public class AIInput : MonoBehaviour, IHandleInput
{
    public Vector3 Move()
    {
        return Vector3.zero;
    }

    public IDragonCommand Action()
    {
        return null;
    }

}
