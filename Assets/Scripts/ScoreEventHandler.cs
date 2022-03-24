using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public delegate void ScoreEventHandler(int increase);
    public static event ScoreEventHandler OnScoreIncrease;

    public delegate void MapEventHandler();
    public static event MapEventHandler OnMapPickup;
    public static event MapEventHandler OnMapUse;

    public static void ScoreIncreased(int increase)
    {
        Debug.Log("Player's score increased by: " + increase);
        OnScoreIncrease(increase);
    }

    public static void MapPickedUp()
    {
        Debug.Log("Player picked up a map.");
        OnMapPickup();
    }

    public static void MapUsed() 
    {
        Debug.Log("Player used their map.");
        OnMapUse();
    }
}
