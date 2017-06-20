using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameMenu : MonoBehaviour {
    public static GameMenu SelectLeve;
   

    void Awake()
    {
        SelectLeve = this;
    }
    public void MainSence()
    {
        Application.LoadLevel(0);//开始界面
    }
    public void OnStart()
    {
        Application.LoadLevel(1);//选关界面
    }
    public void First()
    {
        Application.LoadLevel(2);//第一关
    }
    public void Second()
    {
        GQ.SelectLeve.Leve2=true;
        Application.LoadLevel(3);
       
    }
    public void Thired()
    {
        GQ.SelectLeve.Leve3 = true;
        Application.LoadLevel(4);
    }
    public void Forth()
    {
        GQ.SelectLeve.Leve4 = true;
        Application.LoadLevel(5);
    }
    public void Fifth()
    {
        GQ.SelectLeve.Leve5= true;
        Application.LoadLevel(6);
    }
    public void Sixth()
    {
        GQ.SelectLeve.Leve6 = true;
        Application.LoadLevel(7);
    }
    public void Seventh()
    {
        GQ.SelectLeve.Leve7 = true;
        Application.LoadLevel(8);
    }
    public void Eighth()
    {
        GQ.SelectLeve.Leve8 = true;
        Application.LoadLevel(9);
    }
    public void Nineth()
    {
        GQ.SelectLeve.Leve9 = true;
        Application.LoadLevel(10);
    }
    public void Tenth()
    {
        GQ.SelectLeve.Leve10 = true;
        Application.LoadLevel(11);
    }
    public void OnExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
}
