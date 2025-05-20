using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TowerBluePrint
{
    public GameObject prefab;
    public int cost;

    public int GetSellAmount()
    {
        return cost/2;
    }

}
