using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Twor : MonoBehaviour {

    [HideInInspector]
    public GameObject PTGo;//当前塔台身上的炮台
    [HideInInspector]
    public bool isUpgraded = false;
    [HideInInspector]
    public PTData ptData;
    //建造炮台
    public void BuildPT(PTData PT)
    {
        ptData = PT;
      
        Vector3 v=transform.position;
        v.y=5f;
        PTGo = GameObject.Instantiate(PT.PTPrefab,v,Quaternion.identity);

    }
    //升级
    public void Upgrade()
    {
        if (isUpgraded == true) return;
        Destroy(PTGo);
        isUpgraded = true;
        Vector3 v = transform.position;
        v.y = 5f;
        PTGo = GameObject.Instantiate(ptData.PTPlus, v, Quaternion.identity);
    }
    //销毁
    public void DestroyPT()
    {
        Destroy(PTGo);
        isUpgraded = false;
        PTGo = null;
        ptData = null;
    }
}
