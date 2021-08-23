using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollision : MonoBehaviour
{
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
      Destroy(gameObject);
        KeyCounter.instance.AddKey();
    }
}
