using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    SpriteRenderer _renderer;
    PlayerMapHandler _player;
    int scoreValue = 100;

    void Awake() 
    {
        _renderer = GetComponent<SpriteRenderer>();
        _player = FindObjectOfType<PlayerMapHandler>();
    }

    void Update() 
    {
        if (_player.CheckMapStatus())
            _renderer.color = Color.red;
        else 
            _renderer.color = Color.clear;
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player" && _player.CheckMapStatus())
        {
            EventHandler.ScoreIncreased(scoreValue);
            EventHandler.MapUsed();
            Destroy(gameObject);
        }
    }
}
