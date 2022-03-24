using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    TextMeshProUGUI text;
    string scoreText;
    PlayerScoreHandler _player;
    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        _player = FindObjectOfType<PlayerScoreHandler>();
    }
    

    void Update() 
    {
        scoreText = _player.GetScore().ToString();
        text.SetText(scoreText);
    }
}
