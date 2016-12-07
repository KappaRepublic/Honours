using UnityEngine;
using System.Collections;

public class Crossheir : MonoBehaviour {

	
	// Update is called once per frame
	void Update () 
	{
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.Translate(new Vector3(0.0f, 0.0f, 5.0f));
	}
}
