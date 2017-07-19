using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("" + Hamsnow(4,5));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	int Hamsnow(int a, int b)
	{
		return a + b;
	}

}
