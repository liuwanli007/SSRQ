using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GaneManager : MonoBehaviour {

    public GameObject endUI;
    public Text endText;

    public GameObject NextUI;
    public Text NextText;

    public static GaneManager Instance;

    //暂停UI
    public GameObject PauseToggle;
    public GameObject BeginToggle;

    
    private EnemySpawner enemySpwner;
    void Awake()
    {
        Instance = this;
        enemySpwner = GetComponent<EnemySpawner>();
    }
    public void Win() 
    {
        NextUI.SetActive(true);
        //NextText.text = "胜 利";
    }
    public void Failed()
    {
        enemySpwner.Stop();
        endUI.SetActive(true);
        endText.text = "失 败";
    }
    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void OnNext()
    {

    }
    public void Pause(bool isOn)
    {
      
            Time.timeScale = 0;
            BeginToggle.SetActive(true);
            PauseToggle.SetActive(false);
        
    }
    public void Begin(bool isOn)
    {
            Time.timeScale = 1;
            BeginToggle.SetActive(false);
            PauseToggle.SetActive(true);
    }
   
    //public void Second
}
