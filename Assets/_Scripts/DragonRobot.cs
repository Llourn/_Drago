using UnityEngine;

public class DragonRobot : MonoBehaviour, IHandleInput
{
	
	public Vector3 Move()
	{
		// This is where the move stuff goes
		return Vector3.zero;
	}

	public IDragonCommand Action()
	{

		return null;
	}

}
