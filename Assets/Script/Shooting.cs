using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        
    }

    private void Shoot()
    {
        for (int i = 0; i < pool.bulletList.Count; i++)
        {
            if (!pool.bulletList[i].gameObject.activeInHierarchy)
            {
                Bullet bullet = pool.bulletList[i];
                bullet.gameObject.transform.position = firePoint.position;
                bullet.gameObject.SetActive(true);
                Rigidbody2D rBodyBullet = bullet.gameObject.GetComponent<Rigidbody2D>();
                rBodyBullet.velocity = new Vector2(bullet.bulletSpeed * Time.deltaTime, 0);
                break;
            }
        }
    }
}
