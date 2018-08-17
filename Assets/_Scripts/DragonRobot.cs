using UnityEngine;

public class DragonRobot : MonoBehaviour, IHandleInput
{

	IDragonCommand fireBallCommand = new FireCommand();
	IDragonCommand deflectCommand = new DeflectingCommand();
	IDragonCommand dashCommand = new DashCommand();

	public float timeBetweenFireballs = 1.0f;

	float timeSinceLastFireball = 0.0f;
	
	public Vector3 Move()
	{
		// This is where the move stuff goes
		return Vector3.zero;
	}

	public IDragonCommand Action()
	{
		// This is getting called in update in DragonController.
		if(Time.time - timeSinceLastFireball > timeBetweenFireballs)
		{
			timeSinceLastFireball = Time.time;
			return fireBallCommand;
		}

		return null;
	}

}
