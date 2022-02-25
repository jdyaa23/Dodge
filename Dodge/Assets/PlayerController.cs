using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    //�̵� �ӷ�
    public float speed = 3f;

    //�� �ڽ��� ���� ����
    public GameObject my;

    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã��
        //playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        //������� �������� �Է°��� �����ؼ� ����
        float XInput = Input.GetAxis("Horizontal");
        //Ű���� : 'A' , <- : ���ǹ��� : -1.0f
        //Ű���� : 'D' , -> : ���ǹ��� : +1.0f
        float zInput = Input.GetAxis("Vertical");
        //Ű���� : 'W' , ^ : ���ǹ��� : +1.0f
        //Ű���� : 'S' , v : ���ǹ��� : =1.0f

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = XInput * speed;
        float zSpeed = zInput * speed;


        //Vector3 �ӵ��� (xSpeed, 0f, zSpeed) ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;

            }

       void DierectInput()
    {
        my.SetActive(false);
    }

}
