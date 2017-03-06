using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTarget : MonoBehaviour 
{

	public float smooth = 1.0f;
	private Quaternion targetRot;

	// Use this for initialization
	void Start () 
	{
		targetRot = transform.rotation;
		targetRot *= Quaternion.AngleAxis(-90, Vector3.right);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, 5 * smooth * Time.deltaTime);
	}
}
