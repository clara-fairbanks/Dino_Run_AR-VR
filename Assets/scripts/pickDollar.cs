using UnityEngine;
using System.Collections;

public class pickDollar : MonoBehaviour {

	public GameObject coin;
	int spawnNum = 1;

	void spawn(){
		for (int i = 0; i < spawnNum; i++) {
			Vector3 coinPos = new Vector3 (
				this.transform.position.x + Random.Range (-1.0f, 2.0f),
				this.transform.position.y + Random.Range (0.0f, 1.0f),
				this.transform.position.z + Random.Range (-1.0f, 2.0f));
			Instantiate (coin, coinPos, Quaternion.identity);
		}
	}

}
