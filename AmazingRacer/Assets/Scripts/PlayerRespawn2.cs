using UnityEngine;
using System.Collections;

public class PlayerRespawn2 : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager; 

	// Triggers when the player enters the water
	void OnTriggerEnter(Collider other)
	{
		// Moves the player to the spawn point
		gameManager.PositionPlayer2();
	}
}
