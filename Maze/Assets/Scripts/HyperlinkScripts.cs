using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperlinkScripts : MonoBehaviour
{
    public void OpenRepository()
    {
        Application.OpenURL("https://github.com/M-Wiz/IMM");
    }

    public void OpenSourceCode()
    {
        Application.OpenURL("https://M-Wiz.github.io/IMM");
    }
}
