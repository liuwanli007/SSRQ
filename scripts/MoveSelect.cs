﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSelect : MonoBehaviour {
    public GameObject select;
    private int a = 0;
   public void Move()
    {
       if(a>=2){
           a = 0;
           return;
       }
        a++;
        select.transform.Translate(-808, 0, 0);

    }
   public void Move2()
   {
       if (a<=-2)
       {
           a = 0;
           return;
       }
       a--;
       select.transform.Translate(808, 0, 0);
   }
}