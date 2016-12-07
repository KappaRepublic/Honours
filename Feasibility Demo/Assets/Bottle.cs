using UnityEngine;
using System.Collections;

public class Bottle : MonoBehaviour 
{
	public float speed;
	WiiRemoteManager wrm;

	// Use this for initialization
	void Start () 
	{
		wrm = FindObjectOfType<WiiRemoteManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += transform.right * speed;
	}

	void OnTriggerStay2D(Collider2D col)
	{
		// If the player shoots, destroy this object
		if (Input.GetMouseButtonDown(0) || wrm.bPressed())
		{
			Destroy(this.gameObject);
		}
	}

	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
}
