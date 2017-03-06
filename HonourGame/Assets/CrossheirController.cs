using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossheirController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 pos = Input.mousePosition;
		transform.position = pos;
		
	}
}
