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
            /*쌉동현
            Debug.Log("히히 응가 발싸!!!!!!!!!!!!!!!!!!!! 집에가고싶다 집에가면 앙 금요일 개꿀띠~~ 하면서 게임하려고 컴퓨터를 키는데 히히 할 게임이 없어서 바로 꺼버리고 유튜브 보러 가겠지????????????????씨@@@발 어케 할겜이 하나도 없지????????????????????????????/뚜??????????????????????????바??????????????????? - 쌉동현");
            */
        }
    }
}
