using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
