using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pausepanel;
    // Start is called before the first frame update
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

    // Update is called once per frame
    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
