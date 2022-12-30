using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicScript : MonoBehaviour
{
    public Sprite offmusic;
    public Sprite onmusic;
    public GameObject musbutton;
    public void MusicButton()
    {
        if (GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().enabled)
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().enabled = false;
            musbutton.GetComponent<Image>().sprite = offmusic;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().enabled = true;
            musbutton.GetComponent<Image>().sprite = onmusic;
        }
    }
}
