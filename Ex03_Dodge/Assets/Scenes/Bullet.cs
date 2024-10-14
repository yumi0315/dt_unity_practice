using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    void Start() {
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ��� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        //���ӿ�����Ʈ �Ҹ�(�ı�) : ��Ȱ��ȭ�ʹ� �ٸ� ��, ������ �ƿ� ������� ��.
        //Destroy( gameObject, 3f ); //3���Ŀ� �Ҹ�



    }
    //�浹ó�� �޼ҵ�
    //�Ϲ� �浹: ���� �������� ������ �浹
    void OnCollisionEnter(Collision collision) { //�浹 ����
        Debug.Log("OnCollisionEnter");
    }
    void OnCollisionStay(Collision collision) { //�浹 ������
        Debug.Log("OnCollisionStay");
    }
    void OnCollisionExit(Collision collision) { //�浹 ����
        Debug.Log("OnCollisionExit");
    }

    //Ʈ���� �浹: ���� �������� �ʴ� ���� �浹
    void OnTriggerEnter(Collider other) {
        Debug.Log("OnTriggerEnter");
        if (other.tag == "Player") {
            //Die()�Լ� ȣ��
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null) {
                playerController.Die();
            }
        }
    }
    void OnTriggerStay(Collider other) {
        Debug.Log("OnTriggerStay");
    }
    void OnTriggerExit(Collider other) {
        Debug.Log("OnTriggerExit");
    }

    void Update() {

    }

    //Vector3�� ���� ǥ��
    //Vector3 forward = new Vector3(0f, 0f, 1f);
    //Vector3 back = new Vector3(0f, 0f, -1f);
    //Vector3 right = new Vector3(0f, 0f, 1f);
    //Vector3 left = new Vector3(0f, 0f, -1f);
    //Vector3 up = new Vector3(0f, 1f, 0f);
    //Vector3 down = new Vector3(0f, -1f, 0f);
}