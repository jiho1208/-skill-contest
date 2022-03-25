using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]
    private List<Transform> Points;
    [SerializeField]
    private float MaxDelay = 5;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform bulletSpawn;
    private float Delay;
    private int LNum = 1;
    void Start()
    {
    }

    void Update()
    {
        Delay -= Time.deltaTime;
        Move();
        input();
    }

    void Move()
    {
        transform.position = Points[LNum].position;
    }
 
    void input()
    {
        if (Input.GetKeyUp(KeyCode.A) && LNum != 0)
        {
            LNum--;
        }

        if (Input.GetKeyUp(KeyCode.D) && LNum != 2)
        {
            LNum++;
        }

        if (Input.GetKey(KeyCode.Space) && Delay <= 0)
        {
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            Delay = MaxDelay;
            /*�Ե���
            Debug.Log("���� ���� �߽�!!!!!!!!!!!!!!!!!!!! ��������ʹ� �������� �� �ݿ��� ���ܶ�~~ �ϸ鼭 �����Ϸ��� ��ǻ�͸� Ű�µ� ���� �� ������ ��� �ٷ� �������� ��Ʃ�� ���� ������????????????????��@@@�� ���� �Ұ��� �ϳ��� ����????????????????????????????/��??????????????????????????��??????????????????? - �Ե���");
            */
        }
    }
}
