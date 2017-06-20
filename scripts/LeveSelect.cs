using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LeveSelect : MonoBehaviour
{

    public Text Leve1Text;
    public Text Leve2Text;
    public Text Leve3Text;
    public Text Leve4Text;
    public Text Leve5Text;
    public Text Leve6Text;
    
   
    public Text Leve7Text;
    public Text Leve8Text;
    public Text Leve9Text;
    public Text Leve10Text;
    //public Text Leve11Text;
    //public Text Leve12Text;
    //public Text Leve13Text;
    //public Text Leve14Text;
    //public Text Leve15Text;
    //public Text Leve16Text;
    //public Text Leve17Text;
    //public Text Leve18Text;

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;

    void Start()
    {

        if (GQ.SelectLeve.Leve2 == false)
        {
            Leve2Text.text = "Locked";
            button1.interactable = false;
        }
        if (GQ.SelectLeve.Leve3 == false)
        {
            Leve3Text.text = "Locked";
            button2.interactable = false;
        }
        if (GQ.SelectLeve.Leve4 == false)
        {
            Leve4Text.text = "Locked";
            button3.interactable = false;
        }
        if (GQ.SelectLeve.Leve5 == false)
        {
            Leve5Text.text = "Locked";
            button4.interactable = false;
        }
        if (GQ.SelectLeve.Leve6 == false)
        {
            Leve6Text.text = "Locked";
            button5.interactable = false;
        }
        if (GQ.SelectLeve.Leve7 == false)
        {
            Leve7Text.text = "Locked";
            button7.interactable = false;
        }
        if (GQ.SelectLeve.Leve8 == false)
        {
            Leve8Text.text = "Locked";
            button8.interactable = false;
        }
        if (GQ.SelectLeve.Leve9 == false)
        {
            Leve9Text.text = "Locked";
            button9.interactable = false;
        }
        if (GQ.SelectLeve.Leve10 == false)
        {
            Leve10Text.text = "Locked";
            button10.interactable = false;
        }
        //if (GameMenu.SelectLeve.Leve11== false)
        //{
        //    Leve11Text.text = "Locked";
        //}
        //if (GameMenu.SelectLeve.Leve12 == false)
        //{
        //    Leve12Text.text = "Locked";
        //}
        //if (GameMenu.SelectLeve.Leve13 == false)
        //{
        //    Leve13Text.text = "Locked";
        //}
        //if (GameMenu.SelectLeve.Leve14 == false)
        //{
        //    Leve14Text.text = "Locked";
        //}
        //if (GameMenu.SelectLeve.Leve15 == false)
        //{
        //    Leve15Text.text = "Locked";
        //}
        //if (GameMenu.SelectLeve.Leve16 == false)
        //{
        //    Leve16Text.text = "Locked";
        //}
        //if (GameMenu.SelectLeve.Leve17 == false)
        //{
        //    Leve17Text.text = "Locked";
        //}
        //if (GameMenu.SelectLeve.Leve18 == false)
        //{
        //    Leve18Text.text = "Locked";
        //}
        if (GQ.SelectLeve.Leve2 == true)
        {
            button1.interactable = true;
            Leve2Text.text = "1 - 2";
        }
        if (GQ.SelectLeve.Leve3 == true)
        {
            button2.interactable = true;
            Leve3Text.text = "1 - 3";
        }
        if (GQ.SelectLeve.Leve4 == true)
        {
            button3.interactable = true;
            Leve4Text.text = "1 - 4";
        }
        if (GQ.SelectLeve.Leve5 == true)
        {
            button4.interactable = true;
            Leve5Text.text = "1 - 5";
        }
        if (GQ.SelectLeve.Leve6 == true)
        {
            button5.interactable = true;
            Leve6Text.text = "1 - 6";
        }
        if (GQ.SelectLeve.Leve7 == true)
        {
            Leve7Text.text = "2 - 1";
        }
        if (GQ.SelectLeve.Leve8 == true)
        {
            Leve8Text.text = "2 - 2";
        }
        if (GQ.SelectLeve.Leve9 == true)
        {
            Leve9Text.text = "2 - 3";
        }
        if (GQ.SelectLeve.Leve10 == true)
        {
            Leve10Text.text = "2 - 4";
        }
        //if (GameMenu.SelectLeve.Leve11 == true)
        //{
        //    Leve11Text.text = "2 - 5";
        //}
        //if (GameMenu.SelectLeve.Leve12 == true)
        //{
        //    Leve12Text.text = "2 - 6";
        //}
    }
    public void MainSence()
    {
        Application.LoadLevel(0);
    }
    public void FirstLeve()
    {
        //SceneManager.LoadScene(1);
        Time.timeScale = 1;
        Application.LoadLevel(2);//第一关
    }
    public void SecondLeve()
    {
        Time.timeScale = 1;
        Application.LoadLevel(3);
    }
    public void ThirdLeve()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(1);
        Application.LoadLevel(4);
    }
    public void ForthLeve()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(1);
        Application.LoadLevel(5);
    }
    public void FifthLeve()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(1);
        Application.LoadLevel(6);
    }
    public void SixthLeve()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(1);
        Application.LoadLevel(7);
    }
    public void SeventhLeve()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(1);
        Application.LoadLevel(8);
    }
    public void eighthLeve()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(1);
        Application.LoadLevel(9);
    }
    public void NinethLeve()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(1);
        Application.LoadLevel(10);
    }
    //public void TenthLeve()
    //{
    //    //SceneManager.LoadScene(1);
    //    Application.LoadLevel(11);
    //}
    //public void EleventhLeve()
    //{
    //    //SceneManager.LoadScene(1);
    //    Application.LoadLevel(12);
    //}
    //public void TwelfthLeve()
    //{
    //    //SceneManager.LoadScene(1);
    //    Application.LoadLevel(13);
    //}
}
