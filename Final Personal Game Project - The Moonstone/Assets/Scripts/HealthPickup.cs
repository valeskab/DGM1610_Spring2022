using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

	public int HealthToAdd;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
		return;

	HealthBar.AddPoints (HealthToAdd);

	Destroy (gameObject);
	}
}