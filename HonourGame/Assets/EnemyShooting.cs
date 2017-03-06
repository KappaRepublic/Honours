using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

	public float timer = 0;
	public float cooldown = 0;
	public bool aboutToFire = false;

	public GameObject firingIndicatorCentre, firingIndicatorBorder;
	public GameObject player;
	public GameObject damageEffect;
	public GameObject particles;

	void Start () {
		timer = 5.0f;
		cooldown = Random.Range (3.0f, 10.0f);
		firingIndicatorCentre = transform.GetChild(1).gameObject;
		firingIndicatorBorder = firingIndicatorCentre.transform.GetChild(0).gameObject;
		player = GameObject.FindGameObjectWithTag ("Player");
		damageEffect = GameObject.FindGameObjectWithTag ("DMEffect");
	}

	
	// Update is called once per frame
	void Update () {

		cooldown -= Time.deltaTime;

		if (cooldown < 0 && !aboutToFire) {
			aboutToFire = true;
			timer = 5.0f;
		}

		if (aboutToFire) {
			timer -= Time.deltaTime;
			firingIndicatorCentre.SetActive (true);

			if (timer < 0) {
				aboutToFire = false;
				cooldown = Random.Range (3.0f, 10.0f);
				PlayerController pC = player.GetComponent<PlayerController> ();
				// Decrement player health
				pC.health -= 1;
				// Play damage animation
				damageEffect.GetComponent<Animator>().Play("Damage");
				// Play the firing animation on the enemy
				// Instantiate(particles, transform.GetChild(2));
			}
		} else if (!aboutToFire) {
			firingIndicatorCentre.SetActive (false);
		}
	}
}
