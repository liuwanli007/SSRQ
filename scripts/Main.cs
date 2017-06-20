using UnityEngine;
using System.Collections;

public class example : MonoBehaviour
{
    public void Awake()
    {
        Screen.SetResolution(1024, 768, true);//自己想要的分辨率，比如1024*768，true表示全屏  
        Screen.fullScreen = true;
    }
}