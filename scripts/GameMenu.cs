using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameMenu : MonoBehaviour {

    public void OnStart()
    {
        //SceneManager.LoadScene(1);
        Application.LoadLevel(1);
    }
    public void First()
    {
        //SceneManager.LoadScene(1);
        Application.LoadLevel(2);
    }
    public void Second()
    {
        Application.LoadLevel(3);
    }
    public void Thired()
    {
        Application.LoadLevel(4);
    }
    public void Forth()
    {
        Application.LoadLevel(0);
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
