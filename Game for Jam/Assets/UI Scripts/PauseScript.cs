using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject musoff;
    public GameObject muson;
    public GameObject pausepanel;
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().enabled)
        {
            musoff.SetActive(false);
            muson.SetActive(true);
        }
        else
        {
            muson.SetActive(false);
            musoff.SetActive(true);
        }
    }
    public void ContinueButton()
    {
        pausepanel.gameObject.SetActive(false);
        Time.timeScale = 1;

    }

    public void PauseButton()
    {
        pausepanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }


    public void ExitButton()
    {
        Time.timeScale = 1;
        Destroy(GameObject.FindGameObjectWithTag("Music"));
        SceneManager.LoadScene("Main Menu");
    }

    public void MusicButton()
    {
        if (GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().enabled)
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().enabled = false;
            muson.SetActive(false);
            musoff.SetActive(true);
        }
        else
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().enabled = true;
            musoff.SetActive(false);
            muson.SetActive(true);
        }
    }

}
