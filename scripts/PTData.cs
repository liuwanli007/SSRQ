using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PTData {

    public GameObject PTPrefab;
    public int cost;
    public GameObject PTPlus;
    public int costUpgrade;
    public PTType type;

    public enum PTType{
        PT1,
        PT2,
        PT3
    }
}
 