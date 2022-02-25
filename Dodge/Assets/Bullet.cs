using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    //이동에 사용할 리지드바디 컴포넌트
    private Rigidbody bulletRigidbody;
    //탄알 이동 속력
    public float speed = 8f;

    void Start()
    {
        // 게임 오브젝터에서 Rigidbody 컴포넌트를 찾아 bulletRigidbody 할당
        bulletRigidbody = GetComponent<Rigidbody>();

        // 리지드바디의 속도 = 앞쪽 방향 * 이동 속력
        bulletRigidbody.velocity = transform.forward * speed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
