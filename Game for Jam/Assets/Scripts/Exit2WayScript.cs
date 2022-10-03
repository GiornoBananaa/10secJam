using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit2WayScript : MonoBehaviour
{
	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Time.timeScale = 0;
			SceneManager.LoadScene("Main Menu");

		}
	}
}
