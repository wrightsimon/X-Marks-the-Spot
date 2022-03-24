using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    int damage = 50;
    
    Animator _animator;

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
            _animator.SetTrigger("Explode");
        Destroy(gameObject, 1f);
    }
}
