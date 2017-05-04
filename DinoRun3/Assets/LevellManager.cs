using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevellManager : MonoBehaviour {

	public void LoadScene(string name){
		Application.LoadLevel(name);
	}
}
