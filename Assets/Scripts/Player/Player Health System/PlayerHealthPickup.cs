using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthPickup : MonoBehaviour
{
    public int healthIncrease = 40;
    //public delegate void PlayerHealthIncreaseAction();
    //public static event PlayerHealthIncreaseAction PlayerHealthIncrease;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().playerHealth += healthIncrease;
            Destroy(gameObject);
        }
    }

    //public void PlayerHealthIncreaseEvent()
    //{
        //gameObject.GetComponent<PlayerHealth>().playerHealth += healthIncrease;
    //}
}     

//
//collision.gameObject PlayerHealthIncrease();        
