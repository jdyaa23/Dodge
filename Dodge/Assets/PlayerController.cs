using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;
    //이동 속력
    public float speed = 3f;

    //내 자신을 담을 변수
    public GameObject my;

    void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아
        //playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        //수평축과 수직축의 입력값을 감지해서 저장
        float XInput = Input.GetAxis("Horizontal");
        //키보드 : 'A' , <- : 음의방향 : -1.0f
        //키보드 : 'D' , -> : 양의방향 : +1.0f
        float zInput = Input.GetAxis("Vartical");
        //키보드 : 'W' , ^ : 양의방향 : +1.0f
        //키보드 : 'S' , v : 음의방향 : =1.0f
            }

       void Die()
    {
        my.SetActive(false);
    }

}
