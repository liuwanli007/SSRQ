using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour {
     
    public PTData PT1;
    public PTData PT2;
    public PTData PT3;

    private PTData selectedPT;//当前选择的炮台类型


    public static BuildManager MoneyChange;
    //当前点击的塔台
    private Twor selectTwor;

    public Text moneyText;
    private int money = 500;

    public Animator moneyAnimator;

    //升级UI
    public GameObject upgradeUI;
    public Button upgrade;

    public void ChangeMoney(int change = 50)
    {
        money += change;
        moneyText.text = "￥" + money; 
    }
    void Awake()
    {
        MoneyChange = this;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject()==false)
            {
                //鼠标不再UI界面上
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                bool isCollider = Physics.Raycast(ray,out hit, 1000000, LayerMask.GetMask("Twor"));
                if (isCollider)
                {
                    Twor twor = hit.collider.GetComponent<Twor>();//得到选中的炮台；
                    if (selectedPT != null && twor.PTGo == null)
                    {
                        //当前塔台为空可以创建a
                        if (money > selectedPT.cost)
                        {
                            ChangeMoney(-selectedPT.cost);
                            twor.BuildPT(selectedPT);
                        }
                        else
                        {
                            //提示钱不够
                            moneyAnimator.SetTrigger("Flicker");
                        }
                    }
                    else if(twor.PTGo != null)
                    {
                        //TODO升级炮台
               
                        if (twor == selectTwor && upgradeUI.activeInHierarchy)
                        {
                            HideUpgradeUI();
                        }
                        else
                        {
                            Vector3 v = twor.transform.position;
                            v.y = 5f;
                            ShowUpgradeUI(v, twor.isUpgraded);
                        }
                        selectTwor = twor;
                    }
                }
            }
        }
    }
    public void OnPT1selected(bool isOn)
    {
       
            selectedPT = PT1;
        
    }
    public void OnPT2selected(bool isOn)
    {
       
            selectedPT = PT2;
        
    }
    public void OnPT3selected(bool isOn)
    {
        
            selectedPT = PT3;
        
    }

    void ShowUpgradeUI(Vector3 pos,bool isDisableUpgrade=false)
    {
        upgradeUI.SetActive(true);
        upgradeUI.transform.position = pos;
        upgrade.interactable = !isDisableUpgrade;
    }
    void HideUpgradeUI()
    {
        upgradeUI.SetActive(false);
    }
    public void OnUpgradeButtonDown(){
        if (money >= selectTwor.ptData.costUpgrade)
        {
            ChangeMoney(-selectTwor.ptData.costUpgrade);
            selectTwor.Upgrade();
        }
        else
        {
            //提示钱不够
            moneyAnimator.SetTrigger("Flicker");
        }
        HideUpgradeUI();
    
    }
    public void OnDestroyButtonDown()
    {
        selectTwor.DestroyPT();
        HideUpgradeUI();

    }

}
