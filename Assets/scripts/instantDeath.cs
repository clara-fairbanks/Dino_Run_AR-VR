using UnityEngine;
using System.Collections;


public class Obstacle : MonoBehaviour {

	//box and barrel found here: https://www.assetstore.unity3d.com/en/#!/content/11256

	void OnTriggerEnter(Collider col)
	{
		//if the player hits one obstacle, it's game over
		if(col.gameObject.tag == gameObject(comp)) // if dino collides with fire
		{
			death (); // call function death
		}
	}
}
