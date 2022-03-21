using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float bulletInterval;
    public int rotatePerBullet;
    public Transform firepos;
    public Bullet bulletObj;

    void Start()
    {
        StartCoroutine(TorandoShot());
    }

    void Update()
    {

    }

    public IEnumerator TorandoShot()
    {
        while (true)
        {
            Bullet bullet = Instantiate(bulletObj);
            bullet.transform.position = firepos.position;
            bullet.transform.rotation = firepos.rotation;
            bullet.SetBullet(10, firepos.forward, 10f);

            firepos.Rotate(Vector3.up * rotatePerBullet);
            yield return new WaitForSeconds(bulletInterval);
        }
    }
}
