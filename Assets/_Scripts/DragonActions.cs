using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonActions : MonoBehaviour {
	
	public float fireballSpeed = 1.0f;
	public GameObject fireball;
	public Transform fireballSpawnLocation;
	float[] angleOffset = new float[] {0.25f, 0.0f, -0.25f};

	public GameObject deflector;

	public void LaunchFireball()
	{
		Vector3 currentFireballDirection;
		GameObject ball;

		for(int i = 0; i < angleOffset.Length; i++)
		{
			currentFireballDirection = fireballSpawnLocation.forward + (fireballSpawnLocation.right * angleOffset[i]);

			ball = Instantiate(fireball, this.fireballSpawnLocation.position, Quaternion.identity);
			ball.GetComponent<Rigidbody>().AddForce(
				currentFireballDirection * fireballSpeed,
				ForceMode.Impulse
			);
		}
	}

	public void DeflectorActivate()
	{
		deflector.SetActive(true);
	}

	public void DeflectorDeactivate()
	{
		deflector.SetActive(false);
	}

}
