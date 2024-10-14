using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance3D : MonoBehaviour
{
    private GameObject object1;
    private GameObject object2;

    void Start()
    {
        object1 = GameObject.Find("Cube1");
        object2 = GameObject.Find("Cube2");
        Debug.Log("���ӿ�����Ʈ1 ��ġ:" + object1.transform.position);  // Vector3 Ÿ��
        Debug.Log("���ӿ�����Ʈ2 ��ġ:" + object2.transform.position);

        // ���� ������Ʈ ���� �Ÿ�
        Vector3 pos1 = object1.transform.position;
        Vector3 pos2 = object2.transform.position;
        Vector3 delta1 = pos1 - pos2;
        float distance = delta1.magnitude;
        Debug.Log("�� ���� ������Ʈ ���� �Ÿ�: "+ distance);

        float distance2 = Vector3.Distance(pos1, pos2);
        Debug.Log("�� ���� ������Ʈ ���� �Ÿ�: " + distance2);

        // �� ���ͻ����� ����� �̵��Ÿ� ���ϱ�
        Vector3 currentPos = new Vector3(1, 0, 1);
        Vector3 destPos = new Vector3(5, 3, 5);

        // ���⺤��
        Vector3 direction = (destPos - currentPos).normalized; // ���Ժ��� (����1) ���⼺

        // �������� ���� 10��ŭ ���� ��ġ���� �̵��ϱ�
        Vector3 newPos = currentPos + direction * 10;

    }
}
