using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	public GameObject eventSystem;

	// Use this for initialization
	void Start () 
	{
		
	}

	// reset the game paddle when enabled
	void OnEnable()
	{
		this.gameObject.transform.rotation = Quaternion.identity;
		Debug.Log("Enabled");
	}
	
	// Update is called once per frame
	void Update () 
	{
		// If the wii remote is active
		if (eventSystem.GetComponent<WiiRemoteManager>().isWiiMoteConnected())
		{
			if (eventSystem.GetComponent<WiiRemoteManager>().upPressed())
			{
				float newRotation = this.gameObject.transform.rotation.z + 4.0f;
				this.gameObject.transform.Rotate(new Vector3(0.0f, 0.0f, newRotation));
			}
			if (eventSystem.GetComponent<WiiRemoteManager>().downPressed())
			{
				float newRotation = this.gameObject.transform.rotation.z - 4.0f;
				this.gameObject.transform.Rotate(new Vector3(0.0f, 0.0f, newRotation));
			}
		}

		/*// Keyboard input
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			float newRotation = this.gameObject.transform.rotation.z + 4.0f;
			this.gameObject.transform.Rotate(new Vector3(0.0f, 0.0f, newRotation));
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			float newRotation = this.gameObject.transform.rotation.z - 4.0f;
			this.gameObject.transform.Rotate(new Vector3(0.0f, 0.0f, newRotation));
		}*/

		// Dance pad input
		if (eventSystem.GetComponent<DancePadManager>().leftHeld())
		{
			float newRotation = this.gameObject.transform.rotation.z + 4.0f;
			this.gameObject.transform.Rotate(new Vector3(0.0f, 0.0f, newRotation));
		}
		else if (eventSystem.GetComponent<DancePadManager>().rightHeld())
		{
			float newRotation = this.gameObject.transform.rotation.z - 4.0f;
			this.gameObject.transform.Rotate(new Vector3(0.0f, 0.0f, newRotation));
		}
	}
}
