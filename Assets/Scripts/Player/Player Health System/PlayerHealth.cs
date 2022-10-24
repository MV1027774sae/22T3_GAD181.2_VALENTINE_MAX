using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    private int playerHealthMax = 100;
    
    public int healthIndicator;
    [SerializeField] private TextMeshProUGUI totalPlayerhealth;

    private void Start()
    {
        playerHealth = playerHealthMax;
    }

    private void Update()
    {
        if (playerHealth > 100)
        {
            playerHealth = playerHealthMax;
        }
        
        if (playerHealth <= 0)
        {
            Destroy(gameObject);
        }

        totalPlayerhealth.text = playerHealth.ToString();
    }
}
