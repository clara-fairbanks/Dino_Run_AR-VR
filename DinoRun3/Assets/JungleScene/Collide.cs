using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Explosive")
			Destroy (gameObject);
	}
}
