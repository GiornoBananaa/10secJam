using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathUIscript : MonoBehaviour
{
    // Start is called before the first frame update
    public void YesButton()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void NoButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
