using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathPendulum : MonoBehaviour
{
    public float angle; // 각도

    private float time = 0; // 시간 
    private float speed = 2.0f; // 속도

    private void Update()
    {
        time += Time.deltaTime * speed;
        transform.rotation = MovePendulum();
        // 설정한 각도로 z축이 1부터 -1까지 이동하는 작업이 반복
    }

    // 진자운동 함수 구현
    Quaternion MovePendulum() => Quaternion.Lerp(Quaternion.Euler(Vector3.forward * angle), Quaternion.Euler(Vector3.back * angle), LerpT());

    // 오일러 각(Euler)
    // Transform 컴포넌트의 Rotation 값은 각 축의 각도(Degree)로 설정되어 있음
    // 3개의 축에 대한 회전각도를 표현한 것을 오일러 각이라고 정의
    // 이 오일러 각은 각이 겹치는 상황으로 인해 3축이 아닌 2축으로 계산될 가능성도 존재 (짐벌락 현상)

    // z -> x -> z 순서로 오일러각을 처리하려 함
    // Rx =   1       0       0
    //        0      cos    -sin
    //        0      sin     cos
    // Rz =  cos    -sin      0
    //       sin     cos      0
    //        0       0       1

    // Rz Rx Rz =   cos    -sin      0      1       0       0       cos   -sin    0
    //              sin     cos      0      0      cos    -sin      sin   cos     0
    //               0       0       1      0      sin     cos       0     0      1
    // 오일러 각을 각각 a, b, c라고 정의

    // 결과
    //       cos(a+c)   -sin(a+c)   0
    //       sin(a+c)    cos(a+c)   0
    //          0           0       1
    // 축 이동을 진행하면서 겹치는 구간이 발생 하게 됨

    // Lerp(a, b, t) 함수의 t의 값을 계산하는 함수
    // a지점에서 b지점까지 t간격으로 부드럽게 이동
    float LerpT() => (Mathf.Sin(time) + 1) * 0.5f;

}
