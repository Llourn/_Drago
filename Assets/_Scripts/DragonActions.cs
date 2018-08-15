using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonActions : MonoBehaviour {
	
	public float fireballSpeed = 1.0f;
	public GameObject fireball;
	public Transform fireballSpawnLocation;

	public void LaunchFireball()
	{
		GameObject ball = Instantiate(fireball, this.fireballSpawnLocation.position, Quaternion.identity);
		ball.GetComponent<Rigidbody>().AddForce(-fireballSpawnLocation.right * fireballSpeed, ForceMode.Impulse);
	}
}
