using UnityEngine;
using System.Collections;
using WiimoteApi;

public class WiiRemoteManager : MonoBehaviour {

	// Local variables
	private Wiimote wiiMote;
	private Vector3 wiiMotionPlusOffset = Vector3.zero;

	// Update is called once per frame
	void Update () 
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return;
		}


		// Get the currently connected wii remote
		wiiMote = WiimoteManager.Wiimotes[0];

		Debug.Log("Wii Remote Active");

		int ret;
		do
		{
			ret = wiiMote.ReadWiimoteData();

			if (ret > 0 && wiiMote.current_ext == ExtensionController.MOTIONPLUS)
			{
				Vector3 offset = new Vector3( -wiiMote.MotionPlus.PitchSpeed,
												wiiMote.MotionPlus.YawSpeed,
												wiiMote.MotionPlus.RollSpeed) / 95.0f;
				wiiMotionPlusOffset += offset;

				Debug.Log(wiiMotionPlusOffset.x);
			}
		} while (ret > 0);
	}

	public void findWiiMotes()
	{
		WiimoteManager.FindWiimotes();
	}

	public void cleanUp()
	{
		WiimoteManager.Cleanup(wiiMote);
		wiiMote = null;
	}

	public bool isWiiMoteConnected()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return true;
	}

	public void activateWiiMotionPlus()
	{
		wiiMote.RequestIdentifyWiiMotionPlus();
		if (wiiMote.wmp_attached)
		{
			wiiMote.ActivateWiiMotionPlus();
		}
	}

	public void deactivateWiiMotionPlus()
	{
		wiiMote.DeactivateWiiMotionPlus();
	}

	public bool aPressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.a;
	}

	public bool bPressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.b;
	}

	public bool onePressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.one;
	}

	public bool twoPressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.two;
	}

	public bool upPressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.d_up;
	}

	public bool downPressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.d_down;
	}

	public bool leftPressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.d_left;
	}

	public bool rightPressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.d_right;
	}

	public bool plusPressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.plus;
	}

	public bool minusPressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.minus;
	}


	public bool homePressed()
	{
		// If no wii remote is found, return
		if (!WiimoteManager.HasWiimote())
		{
			return false;
		}
		return wiiMote.Button.home;
	}

	public Vector3 getRemoteOffset()
	{
		return wiiMotionPlusOffset;
	}

	public void setLight(int light)
	{
		wiiMote.SendPlayerLED(light == 0, light == 1, light == 2, light == 3);
	}
}
