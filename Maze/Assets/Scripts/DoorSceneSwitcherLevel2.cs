using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneSwitcherLevel2 : MonoBehaviour
{
    private int key;
    void OnTriggerEnter(Collider other)
    {
        key = KeyCounter.keyCount;
        if (key == 3)
        {
            SceneManager.LoadScene(3);
        }
    }
}
