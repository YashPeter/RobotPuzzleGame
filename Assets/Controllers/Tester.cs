using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("testing");
		Item test = new Item (1);
		Debug.Log (test.returnType());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
