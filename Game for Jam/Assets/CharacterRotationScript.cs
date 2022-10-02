using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotationScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        InvokeRepeating("CharacterRotator", 10, 10);
    }
    void CharacterRotator()
    {
        player.transform.Rotate(0, 0, 180);
    }
}
