using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovementSciprt : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
