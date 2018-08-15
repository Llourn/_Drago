using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
	public GameObject fireballExplosion;

	void OnTriggerEnter(Collider other)
	{
		if(!other.CompareTag("Particle Effect"))
		{
			Instantiate(fireballExplosion, this.transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}

}
