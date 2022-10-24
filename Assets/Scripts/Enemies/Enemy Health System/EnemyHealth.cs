using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    private int enemyHealthMax = 100;

    public Vector3 enemyVector;
    public Transform enemyTransform;
    public GameObject healthPickupPrefab;

    private void Start()
    {
        enemyHealth = enemyHealthMax;
    }

    private void Update()
    {
        if (enemyHealth > 100)
        {
            enemyHealth = enemyHealthMax;
        }

        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
            SpawnHealthPickup();
        }

        
    }
    private void SpawnHealthPickup()
    {
        GameObject healthPickup = Instantiate(healthPickupPrefab) as GameObject;
        healthPickup.transform.position = enemyTransform.position;
    }
}
