using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    float time = 5;
    Vector3 BulletMove = new Vector3(0, 0, 1);
    void Start()
    {
        BulletMove *= speed;
    }

    void Update()
    {
        transform.position += BulletMove * Time.deltaTime;
        time -= Time.deltaTime;
        if (time <= 0)
        {
            Destroy(gameObject);
        }
    }
}
