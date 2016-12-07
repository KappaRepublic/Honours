using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	SortingGameController gameController;

	// Use this for initialization
	void Start () {
		gameController = FindObjectOfType<SortingGameController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "BlueCollider" && this.gameObject.tag == "BlueBall")
		{
			Destroy(this.gameObject);
			gameController.playerScore += 1;

		}
		else if (col.gameObject.tag == "OrangeCollider" && this.gameObject.tag == "OrangeBall")
		{
			Destroy(this.gameObject);
			gameController.playerScore += 1;
		}
	}
}
