using UnityEngine;
using System.Collections;

public class WiiButtonTester : MonoBehaviour {

	public GameObject eventSystem;
	public GameObject[] testButtons;

	// Update is called once per frame
	void Update () 
	{
		// Display pressed buttons
		testButtons[0].SetActive(eventSystem.GetComponent<WiiRemoteManager>().aPressed());
		testButtons[1].SetActive(eventSystem.GetComponent<WiiRemoteManager>().bPressed());
		testButtons[2].SetActive(eventSystem.GetComponent<WiiRemoteManager>().onePressed());
		testButtons[3].SetActive(eventSystem.GetComponent<WiiRemoteManager>().twoPressed());
		testButtons[4].SetActive(eventSystem.GetComponent<WiiRemoteManager>().rightPressed());
		testButtons[5].SetActive(eventSystem.GetComponent<WiiRemoteManager>().downPressed());
		testButtons[6].SetActive(eventSystem.GetComponent<WiiRemoteManager>().upPressed());
		testButtons[7].SetActive(eventSystem.GetComponent<WiiRemoteManager>().leftPressed());
		testButtons[8].SetActive(eventSystem.GetComponent<WiiRemoteManager>().minusPressed());
		testButtons[9].SetActive(eventSystem.GetComponent<WiiRemoteManager>().homePressed());
		testButtons[10].SetActive(eventSystem.GetComponent<WiiRemoteManager>().plusPressed());

	}
}
