using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public GameObject mainMenu, connectionMenu, sortingGameObjects, sortingGameUI, dodgingGameObjects, dodgingGameUI, shootingGameObjects, shootingGameUI;

	public void openConnectionMenu()
	{
		// Close the main menu
		mainMenu.SetActive(false);
		// Open the connection menu
		connectionMenu.SetActive(true);
	}

	public void closeConnectionMenu()
	{
		// Close the connection menu
		connectionMenu.SetActive(false);
		// Open the main menu
		mainMenu.SetActive(true);
	}

	public void openSortingGame()
	{
		mainMenu.SetActive(false);
		sortingGameObjects.SetActive(true);
		sortingGameUI.SetActive(true);
		// paddle.SetActive(true);
	}

	public void closeSortingGame()	
	{
		sortingGameObjects.SetActive(false);
		sortingGameUI.SetActive(false);
		mainMenu.SetActive(true);
		// paddle.SetActive(false);
	}

	public void openDodgingGame()
	{
		mainMenu.SetActive(false);
		dodgingGameObjects.SetActive(true);
		dodgingGameUI.SetActive(true);
	}

	public void closeDodgingGame()	
	{
		dodgingGameObjects.SetActive(false);
		dodgingGameUI.SetActive(false);
		mainMenu.SetActive(true);
	}

	public void openShootingGame()
	{
		shootingGameObjects.SetActive(true);
		shootingGameUI.SetActive(true);
		mainMenu.SetActive(false);
	}

	public void closeShootingGame()
	{
		shootingGameObjects.SetActive(false);
		shootingGameUI.SetActive(false);
		mainMenu.SetActive(true);
	}
}
