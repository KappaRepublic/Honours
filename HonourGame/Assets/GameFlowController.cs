using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlowController : MonoBehaviour 
{

	public int currentWave = 0;
	public int enemyCount = 0;
	public GameObject player;
	public ArrayMagicBullshit[] wavesArrays;

	// Use this for initialization
	void Start () 
	{
		setUpWaves();
		goToNextWave();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Check if the current wave is complete
		if (isWaveComplete())
		{
			goToNextWave();
		}
	}

	/// <summary>
	/// Sets up waves.
	/// </summary>
	void setUpWaves()
	{
		// Loop through each created wave
		for (int i = 0; i < wavesArrays.Length; i++)
		{
			// Do nothing special right now 
		}
	}

	/// <summary>
	/// Gos to next wave.
	/// </summary>
	void goToNextWave()
	{
		switch(currentWave)
		{
			case 0:
				enemyCount = wavesArrays[0].enemyList.Length;
				break;
			case 1:
				enemyCount = wavesArrays[1].enemyList.Length;
				setUpNextWave(1);
				Animator tempAnimator = player.GetComponent<Animator>();
				tempAnimator.Play("anim_playerflow");
				break;
			default:
				break;
		}

		currentWave += 1;
	}

	/// <summary>
	/// Sets up next wave.
	/// </summary>
	void setUpNextWave(int waveNo)
	{
		for (int i = 0; i < wavesArrays[waveNo].enemyList.Length; i ++)
		{
			// Make all enemies of the current wave active
			wavesArrays[waveNo].enemyList[i].SetActive(true);
		}
	}

	bool isWaveComplete()
	{
		if (enemyCount <= 0)
		{
			return true;
		}
		return false;
	}
}
