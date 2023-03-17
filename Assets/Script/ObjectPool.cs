using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private int poolSize = 10;
    [SerializeField] private Bullet bulletPrefab;

    [HideInInspector] public List<Bullet> bulletList = new List<Bullet>();   

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= poolSize; i++)
        {
            Bullet bullet = Instantiate(bulletPrefab, transform);
            bullet.gameObject.SetActive(false);
            bulletList.Add(bullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
