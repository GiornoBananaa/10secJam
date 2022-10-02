using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotationScript : MonoBehaviour
{
	public float Rotationspeed;
	void FixedUpdate()
	{

		if (Input.GetKey(KeyCode.Q))
			transform.Rotate(0, 0, -Rotationspeed);
		if (Input.GetKey(KeyCode.E))
			transform.Rotate(0, 0, Rotationspeed);
	}
}
