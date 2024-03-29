using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Detector))] // 디텍터타입을 대상으로 연결
public class DetectFront : Editor
{
    // GUI 환경에서 처리될 기능을 작성하는 위치
    private void OnSceneGUI()
    {
        Detector detector = (Detector)target; // 타겟을 디텍터로 설정

        Handles.color = Color.red;
        // 핸들을 통해 디텍터의 위치부터 앞으로 2만큼 굵기 3의 선을 그림.
        Handles.DrawLine(detector.transform.position, detector.transform.forward * 2.0f, 3.0f);

        Handles.color = Color.green;

        Handles.DrawLine(Vector3.zero, (AngleDirection(detector.angle) * 0.5f) * detector.radius); // 왼쪽
        Handles.DrawLine(Vector3.zero, (AngleDirection(detector.angle) * -1 * 0.5f) * detector.radius); // 오른쪽

        //// Vector3.up이 시작부분(호), detector의 위치가 중앙위치, up은 법선벡터(직선이나 평면의 기울기나 경사각을 표현할 때, 해당 직선이나 평면에 수직인 벡터)  
        //Handles.DrawWireArc(detector.transform.position, detector.transform.up, Vector3.forward, 360.0f, detector.radius);
    }

    Vector3 AngleDirection(float angle) => new Vector3(Mathf.Cos(angle* Mathf.Deg2Rad), 0, Mathf.Sin(angle * Mathf.Deg2Rad));




}
