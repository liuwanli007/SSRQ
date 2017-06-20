using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT : MonoBehaviour {

    public List<GameObject> enemys = new List<GameObject>(); 
    void OnTriggerEnter(Collider col) 
    {
         if(col.tag=="Enemy")
         {
             enemys.Add(col.gameObject);
         }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Enemy")
        {
            enemys.Remove(col.gameObject);
        }
    }

    public float attackRate = 1; //攻击频率
    private float timer = 0;
     
    public GameObject bulletPerfab;//子弹模型
    public Transform firePosition;
    //是否是激光炮台
    public bool Laser=false;
    public float damageRate = 70;
    public LineRenderer laserRenderer;

    public Transform head;
    void Start()
    {
        timer = attackRate;
    }

    void Update()
    {
        //炮台头部转向
        if (enemys.Count > 0 && enemys[0] != null) 
        {
            Vector3 targetPosition = enemys[0].transform.position;
            targetPosition.y = head.position.y;

            head.LookAt(targetPosition);
        }
        if (Laser == false)
        {
            //子弹攻击
            timer += Time.deltaTime;
            if (enemys.Count > 0 && timer >= attackRate)
            {
                timer = 0;
                Attack();
            }
        }
        else if (enemys.Count > 0)
        {
            if (laserRenderer.enabled == false)
            {
                laserRenderer.enabled = true;
            }
            if (enemys[0] == null)
            {
                UpdateEnemys();
            }
            if (enemys.Count > 0)
            {
                Vector3 v = enemys[0].transform.position;
                v.y = 2.7f;
                laserRenderer.SetPositions(new Vector3[] { firePosition.position, v });
                enemys[0].GetComponent<Enemy>().TakeDamage(damageRate*Time.deltaTime);
            }
        }
        else
        {
            laserRenderer.enabled = false;
        }
        
    }
    //攻击函数
    void Attack()
    {
        if (enemys[0] == null)
        {
            UpdateEnemys();
        }
        if (enemys.Count > 0)
        {
            GameObject bullet = GameObject.Instantiate(bulletPerfab, firePosition.position, firePosition.rotation);
            bullet.GetComponent<Bullet>().SetTarget(enemys[0].transform);
        }
        else
        {
            timer = attackRate;
        }
    }
    //更新敌人数组
    void UpdateEnemys()
    {
        List<int> empty = new List<int>();
        for (int index = 0; index < enemys.Count; index++)
        {
            if (enemys[index] == null)
            {
                empty.Add(index); 
            }
        }

        for (int i = 0; i < empty.Count; i++)
        {
            enemys.RemoveAt(empty[i]-i);
        }
    }
}
