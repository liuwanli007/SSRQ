using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private Transform[] positions;
    private int index = 0;
    public int speed =20;

	// Use this for initialization
	void Start () {
        positions = waypoints.positions;
	}
     void RotateTo()
    {
        if (index > positions.Length - 1) return;
        float current = transform.eulerAngles.y;
        this.transform.LookAt(positions[index].transform);
        Vector3 target = this.transform.eulerAngles;
        float next = Mathf.MoveTowardsAngle(current, target.y, 120 * Time.deltaTime);
        this.transform.eulerAngles = new Vector3(0, next, 0);
    }
     void Move()
     {
         if (index > positions.Length - 1) return;
         Vector3 pos1 = transform.position;
         Vector3 pos2 = positions[index].transform.position;
         float dist = Vector2.Distance(new Vector2(pos1.x, pos1.z), new Vector2(pos2.x, pos2.z));
         if (dist < 1.5f)
         {
             index++;
         }
         transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
         if (index == positions.Length )
         {
             ReachDestination();
           
         }
     }
	// Update is called once per frame
	void Update () {

        RotateTo();
        Move();
	}
    void ReachDestination()
    {
        GameObject.Destroy(this.gameObject);
    }
    void OnDestroy()
    {
        EnemySpawner.CountEnemyAlive--;
       
    }
    public void TakeDamage(int damage)
    {

    }
}
