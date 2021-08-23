using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCollision : MonoBehaviour
{
    public HealthbarController healthbar;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        healthbar.OnTakeDamage(20);
        Destroy(gameObject);
    }
}
