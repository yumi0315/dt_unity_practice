using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    void Start()
    {
        // ���� ������ �Ÿ� ���ϱ�
        float distance = GetDistance(2, 2, 5, 5);
        Debug.Log(distance);
    }

    float GetDistance (float x1, float y1, float x2, float y2) {
        float x_delta = x1 - x2;
        float y_delta = y1 - y2;

        float distance = Mathf.Sqrt(x_delta * x_delta + y_delta * y_delta);

        return distance;
    }


    void Update()
    {
        
    }
}
