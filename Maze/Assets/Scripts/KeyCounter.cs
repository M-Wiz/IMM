using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCounter: MonoBehaviour
{
    public static KeyCounter instance;
    public Text keysText;

    public static int keyCount = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        keysText.text = keyCount.ToString() + " KEYS";
    }

    public void AddKey()
    {
        keyCount += 1;
        keysText.text = keyCount.ToString() + " KEYS";
    }

    public void ResetKey()
    {
        keyCount = 0;
        keysText.text = keyCount.ToString() + " KEYS";
    }
}
