using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	float speed = 0.1f;
	DodgingGameController gameController;

	void Start()
	{
		gameController = FindObjectOfType<DodgingGameController>();
	}

	// Update is called once per frame
	void Update () 
	{
		transform.position += transform.right * speed;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("Collision");
		if (col.gameObject.tag == "DodgePlayer")
		{
			gameController.playerScore = 0;
			Destroy(this.gameObject);
		}
	}

	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
}
