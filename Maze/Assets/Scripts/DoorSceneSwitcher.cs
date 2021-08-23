using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneSwitcher : MonoBehaviour
{
    private int key;
    void OnTriggerEnter(Collider other)
    {
        key = KeyCounter.keyCount;
       if (key == 3)
        {
            KeyCounter.instance.ResetKey();
            SceneManager.LoadScene(2);
        }
    }
}
