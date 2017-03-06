using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour 
{

	public GameObject player;

	public GameObject reloadNotification;
	public GameObject[] bulletIcons;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		showNotifications();
		updateHUD();	
	}

	/// <summary>
	/// Shows the notifications.
	/// </summary>
	void showNotifications()
	{
		PlayerController tempPController = player.GetComponent<PlayerController>();

		if (tempPController.bullets <= 0)
		{
			reloadNotification.SetActive(true);
		}
		else
		{
			reloadNotification.SetActive(false);
		}
	}

	/// <summary>
	/// Updates the HUD.
	/// </summary>
	void updateHUD()
	{
		PlayerController tempPController = player.GetComponent<PlayerController>();
		for (int i = 0; i < tempPController.bullets; i ++)
		{
			bulletIcons[i].SetActive(true);
		}
		for (int i = tempPController.bullets; i < 6; i++)
		{
			bulletIcons[i].SetActive(false);
		}
	}
}
