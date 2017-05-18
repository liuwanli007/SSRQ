using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public int speed = 1;
    public int mousespeed = 100;
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float mouse = Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(new Vector3(h,mouse*mousespeed, v) * Time.deltaTime*speed,Space.World);

	}
}
