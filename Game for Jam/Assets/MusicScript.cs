using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public GameObject musicobj;
    bool music;
    void Start()
    {
        music = true;
    }
    public void MusicButton()
    {
        if (music == true)
        {
            music = false;
            musicobj.SetActive(false);
        }
        else
        {
            music = true;
            musicobj.SetActive(true);
        }
    }
}
