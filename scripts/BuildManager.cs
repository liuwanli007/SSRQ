using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class BuildManager : MonoBehaviour {
    public PTData PT1Data;
    public PTData PT2Data;
    public PTData PT3Data;
    //被选中的炮台类型
    private PTData selectedPT; 

    public Animator moneyAnimator;
    public Text moneyText;
    public int money = 1000;


    public void ChangeMoney(int change=50)
    {
        money += change;
        moneyText.text = "￥" + money;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject()==false)
            {
                //开发炮台的建造
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                bool isCollider = Physics.Raycast(ray,out hit,1000,LayerMask.GetMask("Twor"));
                if (isCollider)
                {
                    Twor twor = hit.collider.GetComponent<Twor>();
                    if (selectedPT != null && twor.PTGo == null)
                    { 
                        if (money > selectedPT.cost)
                        {
                            ChangeMoney(-selectedPT.cost);
                            twor.BuildPT(selectedPT.PTPerfab);   
                        }
                        else
                        {
                            //钱不够； 
                            moneyAnimator.SetTrigger("Flicker"); 
                        }
                    }
                    else
                    {
                        //TODO
                    }
                }
            }
        }
    }
    public void OnPT1Selected(bool inOn)
    {
        if (inOn)
        {
            selectedPT = PT1Data;
        }
    }
    public void OnPT2Selected(bool inOn)
    {
        if (inOn)
        {
            selectedPT = PT2Data;
        }
    }
    public void OnPT3Selected(bool inOn)
    {
        if (inOn)
        {
            selectedPT = PT3Data;
        }
    } 
}
