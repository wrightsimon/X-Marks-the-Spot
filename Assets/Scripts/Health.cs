using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Sprites for healthy, damaged, dying, and dead.
    [SerializeField]
    Sprite[] Sprites;
    public GameObject map;
    
    public int maxHealth = 100;
    int health;

    SpriteRenderer _renderer;

    void Awake() 
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Start() 
    {
        health = maxHealth;
    }

    public void TakeDamage(int dmg) 
    {
        Debug.Log(name + " is taking " + dmg);
        health -= dmg;
        UpdateSprite();
        if (health <= 0)
            Die();
    }

    void UpdateSprite() 
    {
        if (health > maxHealth / 2)
            _renderer.sprite = Sprites[0];

        if (health <= maxHealth / 2)
            _renderer.sprite = Sprites[1];

        if (health <= maxHealth / 4)
            _renderer.sprite = Sprites[2];

        if (health <= 0) 
            _renderer.sprite = Sprites[3];
    }

    void Die()
    {
        Debug.Log(name + " going down!");
        //play death animation
        //if enemy ship, drop map
        //if player, end game
        if (gameObject.tag == "Enemy")
            DropMap();
        Destroy(gameObject, 0.5f);
    }

    void DropMap() {
        Instantiate(map, transform.position, Quaternion.identity);
    }
}
