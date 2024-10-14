using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;   // 이동에 사용할 리지드바드 컴포넌트
    public float speed = 8f;            // 이동 속력

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow)) { // 화살표 위 키
        //    playerRigidbody.AddForce(0f, 0f, speed);    // Z + 쪽으로
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
        // 수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0, zSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // Rigidbody에 속도를 적용
        playerRigidbody.velocity = newVelocity; // 속도 = 거리 / 시간
    }

    public void Die() { // 충돌시 수행되는 코드
        // 게임오브젝트 비활성화
        gameObject.SetActive(false);

        // gameObject : 예약어, 자기 게임오브젝트
        // transform : 예약어, 자기 트랜스폼 컴포넌트
        // 나머지 컴포넌트들은 모두 다 public link나 getComponent을 통해 가져온다.
        //playerRigidbody = gameObject.GetComponent<Rigidbody>();
        //CapsuleCollider colider = gameObject.GetComponent<CapsuleCollider>();


    }

}
