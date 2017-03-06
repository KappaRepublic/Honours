using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterController : MonoBehaviour 
{
	// Return universla inputs based on all possible controllers

	/// <summary>
	/// Rights the pressed.
	/// </summary>
	/// <returns><c>true</c>, if pressed was righted, <c>false</c> otherwise.</returns>
	public bool rightPressed()
	{
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			return true;
		}
		return false;
	}

	/// <summary>
	/// Lefts the pressed.
	/// </summary>
	/// <returns><c>true</c>, if pressed was lefted, <c>false</c> otherwise.</returns>
	public bool leftPressed()
	{
		if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
		{
			return true;
		}
		return false;
	}

	/// <summary>
	/// Downs the held.
	/// </summary>
	/// <returns><c>true</c>, if held was downed, <c>false</c> otherwise.</returns>
	public bool downHeld()
	{
		if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			return true;
		}
		return false;
	}

	/// <summary>
	/// Fires the gun.
	/// </summary>
	/// <returns><c>true</c>, if gun was fired, <c>false</c> otherwise.</returns>
	public bool fireGun()
	{
		if(Input.GetMouseButtonDown(0))
		{
			return true;
		}
		return false;
	}

	/// <summary>
	/// Reload thie gun
	/// </summary>
	public bool reload()
	{
		if(Input.GetKeyDown(KeyCode.R))
		{
			return true;
		}
		return false;
	}
}
