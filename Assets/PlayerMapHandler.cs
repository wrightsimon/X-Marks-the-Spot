using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMapHandler : MonoBehaviour
{
    bool hasMap;

    void Start()
    {
        EventHandler.OnMapPickup += CollectMap;
        EventHandler.OnMapUse += UseMap;
    }

    public void CollectMap() 
    {
        hasMap = true;
    }

    public void UseMap() 
    {
        hasMap = false;
    }

    public bool CheckMapStatus() 
    {
        return hasMap;
    }
}
