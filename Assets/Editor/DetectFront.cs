using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Detector))] // ������Ÿ���� ������� ����
public class DetectFront : Editor
{
    // GUI ȯ�濡�� ó���� ����� �ۼ��ϴ� ��ġ
    private void OnSceneGUI()
    {
        Detector detector = (Detector)target; // Ÿ���� �����ͷ� ����

        Handles.color = Color.red;
        // �ڵ��� ���� �������� ��ġ���� ������ 2��ŭ ���� 3�� ���� �׸�.
        Handles.DrawLine(detector.transform.position, detector.transform.forward * 2.0f, 3.0f);

        Handles.color = Color.green;

        Handles.DrawLine(Vector3.zero, (AngleDirection(detector.angle) * 0.5f) * detector.radius); // ����
        Handles.DrawLine(Vector3.zero, (AngleDirection(detector.angle) * -1 * 0.5f) * detector.radius); // ������

        //// Vector3.up�� ���ۺκ�(ȣ), detector�� ��ġ�� �߾���ġ, up�� ��������(�����̳� ����� ���⳪ ��簢�� ǥ���� ��, �ش� �����̳� ��鿡 ������ ����)  
        //Handles.DrawWireArc(detector.transform.position, detector.transform.up, Vector3.forward, 360.0f, detector.radius);
    }

    Vector3 AngleDirection(float angle) => new Vector3(Mathf.Cos(angle* Mathf.Deg2Rad), 0, Mathf.Sin(angle * Mathf.Deg2Rad));




}
