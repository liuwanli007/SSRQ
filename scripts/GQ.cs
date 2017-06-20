using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GQ : MonoBehaviour {
    public static GQ SelectLeve;
    public bool Leve2=false;
    public bool Leve3=false;
    public bool Leve4 = false;
    public bool Leve5 = false;
    public bool Leve6 = false;
    public bool Leve7 = false;
    public bool Leve8 = false;
    public bool Leve9 = false;
    public bool Leve10 = false;


    void Awake()
    {
        SelectLeve = this;
    }
    public void SetLeve2()
    {
        Leve2 = true;
    }
}
