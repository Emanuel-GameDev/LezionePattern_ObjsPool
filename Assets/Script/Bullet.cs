using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 1;

    private void OnEnable()
    {
        Invoke("Hide", 2f);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}

