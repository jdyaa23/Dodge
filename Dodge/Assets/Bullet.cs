using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    //�̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody bulletRigidbody;
    //ź�� �̵� �ӷ�
    public float speed = 8f;

    void Start()
    {
        // ���� �������Ϳ��� Rigidbody ������Ʈ�� ã�� bulletRigidbody �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
