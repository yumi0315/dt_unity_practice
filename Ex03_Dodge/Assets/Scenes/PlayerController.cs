using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;   // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;            // �̵� �ӷ�

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow)) { // ȭ��ǥ �� Ű
        //    playerRigidbody.AddForce(0f, 0f, speed);    // Z + ������
        //}
        //if (Input.GetKey(KeyCode.DownArrow)) { 
        //    playerRigidbody.AddForce(0f, 0f, -speed);    
        //}
        //if (Input.GetKey(KeyCode.LeftArrow)) {
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}
        //if (Input.GetKey(KeyCode.RightArrow)) {
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}
        // ������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // Rigidbody�� �ӵ��� ����
        playerRigidbody.velocity = newVelocity; // �ӵ� = �Ÿ� / �ð�
    }

    public void Die() { // �浹�� ����Ǵ� �ڵ�
        // ���ӿ�����Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);

        // gameObject : �����, �ڱ� ���ӿ�����Ʈ
        // transform : �����, �ڱ� Ʈ������ ������Ʈ
        // ������ ������Ʈ���� ��� �� public link�� getComponent�� ���� �����´�.
        //playerRigidbody = gameObject.GetComponent<Rigidbody>();
        //CapsuleCollider colider = gameObject.GetComponent<CapsuleCollider>();


    }

}
