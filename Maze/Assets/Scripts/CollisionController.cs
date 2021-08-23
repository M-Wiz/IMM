using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public HealthbarController healthbar;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mine")
        {
            if (healthbar)
            {
                healthbar.OnTakeDamage(34);
            }
        }
    }

 
}
