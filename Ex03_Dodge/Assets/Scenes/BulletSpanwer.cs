using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpanwer : MonoBehaviour {
    public GameObject bulletPrefab; //������ ź���� ���� ������
    public float spawnRateMin = 0.5f; //�ּ� ���� �ֱ�
    public float spawnRateMax = 3.0f; //�ִ� ���� �ֱ�

    private Transform target; //�߻��� ���(Player)
    private float spawnRate; //���� �ֱ�
    private float timeAfterSpawn; //�ֱ� ���� �������� ���� �ð�

    void Start() {
        timeAfterSpawn = 0; //�ֱ� ���� ������ �ð��� 0���� �ʱ�ȭ
        spawnRate = Random.Range(spawnRateMin, spawnRateMax); //���� �ð��� ���� ����
        target = GameObject.Find("Player").transform;

        //��(������)���� ���ӿ�����Ʈ�� ã�� ���
        GameObject player = GameObject.Find("Player"); //�ӵ� ����.
        GameObject player2 = GameObject.FindWithTag("Player");
        //Ư�� ���۳�Ʈ�� ������ ���ӿ�����Ʈ ã��
        GameObject player3 = FindObjectOfType<PlayerController>().gameObject;
        //public link : ���� - ���ӿ�����Ʈ �Ҹ�ÿ� ��ũ�� ����.
        //public GameObject player4;
    }

    void Update() // �� �����Ӹ��� ����Ǵ� �Լ� ��)30fps = 0.033�и��ʸ��� ����
    {
        //deltaTime : �� �����Ӹ��� ���� �ð�, FPS�� �޶����� ������ �ð� ������ �����Ϸ���.
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn > spawnRate) {
            //ź�� ���� ������ ��.
            timeAfterSpawn = 0; //������ �ð��� ������ ��.

            //���������κ��� ź���� ���� �����Ͽ� ����(������)�� �����Ѵ�.
            GameObject bullet = Instantiate(bulletPrefab, transform.position,
                transform.rotation);
            //ź���� Ÿ���� ���� �ٶ󺸵���(forward z+������ ����) �Ѵ�.
            bullet.transform.LookAt(target);

            //���� ź�� ���� �ð� ���� ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}