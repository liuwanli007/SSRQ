using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PTData 
    {
        public GameObject PTPerfab;
        public int cost;
        public GameObject UpgradedPT;
        public int costUpgraded;
        public PTType type;
    }
	public enum PTType
    {
        PT1,
        PT2,
        PT3,
    }

