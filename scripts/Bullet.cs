using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int damage = 50;
    public float speed = 20;

    public GameObject explosionEffect;
    private Transform target;

    private float distanceArriveTarget = 1.2f;
	public void  SetTarget(Transform _target)
    {
        this.target = _target;
    }
    void Update()
    {
        if (target == null)
        {
            Die();
            return;
            
        }
        Vector3 v =target.position;
        v.y = 2.7f;
        transform.LookAt(v);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        Vector3 dir = v - transform.position;
        if (dir.magnitude <= distanceArriveTarget)
        {
            target.GetComponent<Enemy>().TakeDamage(damage);
            Die();
        }
        
    }
    void Die()
    {
        if (target == null)
        {
            GameObject effect1 = GameObject.Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(effect1, 1);
            Destroy(this.gameObject);
            return;
        }
        Vector3 v = target.position;
        v.y = 2.7f;
        GameObject effect = GameObject.Instantiate(explosionEffect, v, transform.rotation);
        Destroy(effect, 1);
        Destroy(this.gameObject);
    }
   
}
