using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamWeapon : MonoBehaviour
{
    public int damage = 20;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
