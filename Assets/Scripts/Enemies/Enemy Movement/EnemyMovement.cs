using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform Player;
    public float enemySpeed = 3f;
    private int minDistance = 0;

    private void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= minDistance)
        {
            transform.position += transform.forward * enemySpeed * Time.deltaTime;
        }
    }
}
