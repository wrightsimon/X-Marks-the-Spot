using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreHandler : MonoBehaviour
{
    int score = 0;

    void Start() 
    {
        EventHandler.OnScoreIncrease += IncreaseScore;
    }

    void IncreaseScore(int increase)
    {
        score += increase;
    }

    public int GetScore()
    {
        return score;
    }
}
