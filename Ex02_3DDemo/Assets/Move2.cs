using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public GameObject cube2;
    void Start()
    {
        // �ڽ��� ������ Y�� ���� 45�� ����
        // rotation�� ���ʹϾ����� �Ǿ� ����: 4���� ������.
        transform.rotation = Quaternion.Euler(new Vector3(0, 45, 0));
        //transform.Rotate(new Vector3(0, 45, 0));

        
    }

    // Update is called once per frame
    void Update()
    {
        // �۷ι� ��ǥ��� �̵�
        //transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime, Space.World); // Space.World �۷ι���ǥ��

        // ���� ��ǥ��� �̵�
        //transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime, Space.Self);

        //cube2.transform.Translate(new Vector3(1,0,0) * Time.deltaTime, Space.Self);
        cube2.transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime, Space.Self);
    }
}
