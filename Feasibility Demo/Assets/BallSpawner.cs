using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject[] balls;

	// Use this for initialization
	void OnEnable () 
	{
		spawnBall();
	}

	public void spawnBall()
	{
		// Spawn a new ball
		int random = Random.Range(0, balls.Length);
		float offset = Random.Range(-1.0f, 1.0f);

		Vector3 pos = transform.position;
		pos.x = pos.x + offset;

		Instantiate(balls[random], pos, Quaternion.identity);
	}

}
