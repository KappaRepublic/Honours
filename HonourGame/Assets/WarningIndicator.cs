using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningIndicator : MonoBehaviour {

	/// <summary>
	/// The warning sprites.
	/// </summary>
	public Sprite[] warningSprites;

	float timer = 10.0f;
	int index = 0;

	void Start()
	{
		// GetComponent<SpriteRenderer>().sprite = warningSprites[4];
	}

	void Update()
	{
		timer -= 1.0f;

		if (timer <= 0.0f)
		{
			index += 1;
			if (index > 8)
			{
				index = 0;
			}

			GetComponent<SpriteRenderer>().sprite = warningSprites[index];

			timer = 10.0f;
		}


	}
}
