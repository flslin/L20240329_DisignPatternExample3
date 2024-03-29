using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigonometry : MonoBehaviour
{
    // 게임 수학에서 다루는 것들
    // 1. 삼각함수
    // 2. 좌표
    // 3. 벡터
    // 4. 행렬
    // 5. 사원수 (오일러, 짐벌락)
    // 6. 곡선

    // 1-1 삼각함수
    // 사인(sin A)    a/h
    // -> 각도를 angle이라고 할때 h와 높이의 비율을 sin이라고 정의
    // -> h의 길이와 각도를 알고 있다면 h의 길이 * sin angle을 통해 높이의 길이를 구할 수 있습니다.
    // (유니티에서 좌표상의 y)

    // 코사인         b/h
    // -> h와 cos angle을 통해 b를 계산하는 것이 가능(유니티에서 좌표상의 x)

    // 탄젠트         a/b

    // 삼각함수 사용 목적 : 원형 움직임 구현, 부채꼴 움직임 구현, 벡터의 좌표 계산. 각도로 방향벡터 계산하기, 두 벡터 사이의 각도 계산(벡터의 내적)

    // 라디안 (radian) : 호도법
    // 수학과 프로그래밍 분야에서 각도를 나타내는 기준
    // 어느 한 원 위의 점이 원점을 중심으로 반지름의 길이만큼 한 방향으로 움직였을 때 대응하는 각의 크기를 1 라디안이라고 정의함
    // 일반적인 각도 (Degree) 약 60도 == 1 라디안 
    // 사용목적 : 라디안으로 표현하는게 파이를 이용한 도수법으로 표현하는 것보다 쉬워서 (컴퓨터가)

    // Mathf.Deg2Rad을 통해 각도를 라디안으로 변경

    private void Start()
    {
        float angle = 45; // 각도
        // 유니티 내에 존재하는 삼각함수
        Debug.Log(Mathf.Sin(angle * Mathf.Deg2Rad));
        Debug.Log(Mathf.Cos(angle * Mathf.Deg2Rad));
        Debug.Log(Mathf.Tan(angle * Mathf.Deg2Rad));
        // 유니티에서 준 sin, cos 함수에서 h의 값은 1로 설정되어있음
        // 따라서 Sin, Cos은 다음과 같음

        Vector2 vector2;
        vector2.x = Mathf.Cos(angle * Mathf.Deg2Rad);
        vector2.y = Mathf.Sin(angle * Mathf.Deg2Rad);

        // x는 삼각형의 밑변(a), y는 삼각형의 높이(b)
        // 현재 빗변이 1이고 각도가 45도인 삼각형의 꼭짓점의 위치를 파악한 상태

    }

    private void Update()
    {
        //Vector2 vector2;
        //vector2.x = Mathf.Cos(Time.time * 180 * Mathf.Deg2Rad);
        //vector2.y = Mathf.Sin(Time.time * 180 * Mathf.Deg2Rad);
        //transform.position = vector2;

    }

}
