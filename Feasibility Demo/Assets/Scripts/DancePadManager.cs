using UnityEngine;
using System.Collections;

public class DancePadManager : MonoBehaviour {

	public bool upStomp()
	{
		return Input.GetButtonDown("DancePadUp");
	}

	public bool downStomp()
	{
		return Input.GetButtonDown("DancePadDown");
	}

	public bool leftStomp()
	{
		return Input.GetButtonDown("DancePadLeft");
	}

	public bool rightStomp()
	{
		return Input.GetButtonDown("DancePadRight");
	}

	public bool xStomp()
	{
		return Input.GetButtonDown("DancePadX");
	}

	public bool circleStomp()
	{
		return Input.GetButtonDown("DancePadCircle");
	}

	public bool triangleStomp()
	{
		return Input.GetButtonDown("DancePadTriange");
	}

	public bool squareStomp()
	{
		return Input.GetButtonDown("DancePadSquare");
	}

	public bool upHeld()
	{
		return Input.GetButton("DancePadUp");
	}

	public bool downHeld()
	{
		return Input.GetButton("DancePadDown");
	}

	public bool leftHeld()
	{
		return Input.GetButton("DancePadLeft");
	}

	public bool rightHeld()
	{
		return Input.GetButton("DancePadRight");
	}

	public bool xHeld()
	{
		return Input.GetButton("DancePadX");
	}

	public bool circleHeld()
	{
		return Input.GetButton("DancePadCircle");
	}

	public bool triangleHeld()
	{
		return Input.GetButton("DancePadTriange");
	}

	public bool squareHeld()
	{
		return Input.GetButton("DancePadSquare");
	}

}
