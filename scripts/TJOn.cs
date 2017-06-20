using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TJOn : MonoBehaviour {
    public GameObject Tj;
    public GameObject Us;
    public void TjOn()
    {
        Tj.SetActive(true);
    }
    public void TjOff()
    {
        Tj.SetActive(false);
    }
    public void UsOn()
    {
        Us.SetActive(true);
    }
    public void UsOff()
    {
        Us.SetActive(false);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
