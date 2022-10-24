using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContactDamage : MonoBehaviour
{
    public int collisionDamage = 15;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        collision.gameObject.GetComponent<PlayerHealth>().playerHealth -= collisionDamage;
    }
}
