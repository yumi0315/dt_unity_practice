using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody playerRididbody;//이동에 사용할 리지드바드 컴포넌트
    public float speed = 8f; //이동 속력

    void Start() {
        playerRididbody = GetComponent<Rigidbody>();
    }

    void Update() {
        //수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal"); //-1.0 ~ 1.0
        float zInput = Input.GetAxis("Vertical"); //-1.0 ~ 1.0
        //Debug.Log("xInput:"+xInput+", zInput:"+zInput);

        //실제 이동속도를 입력값과 이동 속도를 사용해 결정
        float xSpeed = xInput * speed; //-8f ~ 8f
        float zSpeed = zInput * speed; //-8f ~ 8f

        //Vector3 속도를 (xSpeed, 0, zSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //Rigidbody에 속도를 적용
        playerRididbody.velocity = newVelocity;  //속도 = 거리 / 시간
    }
    public void Die() { //충돌시 수행되는 코드
        //게임오브젝트 비활성화
        gameObject.SetActive(false);

        //gameObject : 예약어, 자기 게임오브젝트
        //transform : 예약어, 자기 트랜스폼 컴포넌트
        //나머지 컴포넌트들은 모두 다 public link나 GetComponent을 통해 가져온다.
        //playerRididbody = gameObject.GetComponent<Rigidbody>();
        //CapsuleCollider colider = gameObject.GetComponent<CapsuleCollider>();
        //PlayerController script = gameObject.GetComponent<PlayerController>();
    }
}