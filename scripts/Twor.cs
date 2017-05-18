using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twor : MonoBehaviour {

    [HideInInspector]
    public GameObject PTGo;

    public void BuildPT(GameObject PTPrefab)
    {
       Vector3 pos= transform.position;
       pos.y = 2.5f;
       PTGo = GameObject.Instantiate(PTPrefab, pos, Quaternion.identity);
    }
}
