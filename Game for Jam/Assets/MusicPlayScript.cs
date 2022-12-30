using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayScript : MonoBehaviour
{
    void Start()
    {
        try
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusiccontinueScript>().PlayMusic();

        }
        catch
        {

        }
    }
}
