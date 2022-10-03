using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit1WayScipt : MonoBehaviour
{
	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			SceneManager.LoadScene("Level 2");
		}
	}
}
