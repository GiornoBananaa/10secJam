using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovementSciprt : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
    void Start()
    {
        InvokeRepeating("CharacterRotator", 10, 10);
    }
    void CharacterRotator()
    {
        transform.Rotate(0, 0, 180);
    }
}
