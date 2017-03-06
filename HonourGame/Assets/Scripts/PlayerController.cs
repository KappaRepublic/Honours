using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{

	public float smooth = 1.0f;
	private Quaternion targetRot;

	// Player stats
	public const int maxBullets = 6;
	public int bullets;

	public const int maxHealth = 3;
	public int health;
	public GameObject[] healthObjects;

	// GameObjects
	public GameObject mController;
	public GameObject shotParticle;

	// Audio
	public AudioClip gunShotSound;
	public AudioClip gunReloadSound;
	public AudioClip gunNoAmmoSound;
	AudioSource audio;

	public bool inCover;

	// Private variables
	private float standardCamHeight = 0.0f;
	private float crouchDelta = -0.5f;
	private MasterController mCon;
	private GameFlowController flowCon;

	// Use this for initialization
	void Start () 
	{
		targetRot = transform.rotation;
		bullets = maxBullets;
		health = maxHealth;
		inCover = false;
		audio = GetComponent<AudioSource>();
		mCon = mController.GetComponent<MasterController>();
		flowCon = mController.GetComponent<GameFlowController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Update based on input
		if (mCon.leftPressed())
		{
			// Rotate Left
			targetRot *= Quaternion.AngleAxis(-90, Vector3.up);
			// transform.Rotate(-Vector3.up * speed * Time.deltaTime);
		}
		else if (mCon.rightPressed())
		{
			// Rotate Right
			targetRot *= Quaternion.AngleAxis(90, Vector3.up);
			// transform.Rotate(Vector3.up * speed * Time.deltaTime);
		}

		if(mCon.downHeld())
		{
			inCover = true;
		}
		else
		{
			inCover = false;
		}

		// Shooting
		if (mCon.fireGun() && !inCover)
		{
			if (bullets > 0)
			{
				// Start the ray cast
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast (ray, out hit, 100.0f))
				{
					Debug.Log("You have hit " + hit.transform.name);
					// Play particle system at hit
					Instantiate(shotParticle, hit.point, hit.transform.rotation);
					// If the hit object is destroyable, destroy it
					if (hit.collider.gameObject.tag == "Target")
					{
						Destroy(hit.collider.gameObject);

						// Decrease the enemy count by 1
						flowCon.enemyCount -= 1;
					}
				}

				// Play a gunshot noise
				audio.PlayOneShot(gunShotSound, 1.0f);

				// Decrement current bullets
				bullets -= 1;
			}
			else
			{
				// Play the no bullet sound
				audio.PlayOneShot(gunNoAmmoSound, 1.0f);
			}
		}

		// Reloading
		// NOTE:
		// Keyboard: "R" key is pressed
		// Controller: "SQUARE" is pressed
		// Wiiremote: Shoot of screen
		if (mCon.reload())
		{
			// Play a reload noise
			audio.PlayOneShot(gunReloadSound, 1.0f);
			// Refill player bullets
			bullets = maxBullets;
		}

		// Update player transform per frame
		transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, 10 * smooth * Time.deltaTime);

		if (inCover)
		{
			Debug.Log("Crouching");
			transform.position = new Vector3(transform.position.x, crouchDelta, transform.position.z);
		}
		else
		{
			transform.position = new Vector3(transform.position.x, standardCamHeight, transform.position.z);
		}

		// Draw current health
		for (int i = 0; i < maxHealth; i++) {
			healthObjects [i].SetActive(false);
		}
		for (int i = 0; i < health; i++) {
			healthObjects [i].SetActive(true);
		}
			
	}
}
