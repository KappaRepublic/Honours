using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour {

	public GameObject bullet;
	float spawnTimer, coolDown;

	// Use this for initialization
	void OnEnable () 
	{
		setRandomTime();
	}
	
	// Update is called once per frame
	void Update () 
	{
		spawnTimer += Time.deltaTime;

		// If time to spawn bullet
		if (spawnTimer >= coolDown)
		{
			spawnBullet();
			setRandomTime();
			spawnTimer = 0.0f;
		}
	}

	void spawnBullet()
	{
		Instantiate(bullet, transform.position, transform.rotation);
	}

	void setRandomTime()
	{
		coolDown = Random.Range(4.0f, 25.0f);
	}
}
