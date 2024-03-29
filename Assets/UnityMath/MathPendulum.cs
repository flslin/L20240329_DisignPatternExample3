using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathPendulum : MonoBehaviour
{
    public float angle; // ����

    private float time = 0; // �ð� 
    private float speed = 2.0f; // �ӵ�

    private void Update()
    {
        time += Time.deltaTime * speed;
        transform.rotation = MovePendulum();
        // ������ ������ z���� 1���� -1���� �̵��ϴ� �۾��� �ݺ�
    }

    // ���ڿ �Լ� ����
    Quaternion MovePendulum() => Quaternion.Lerp(Quaternion.Euler(Vector3.forward * angle), Quaternion.Euler(Vector3.back * angle), LerpT());

    // ���Ϸ� ��(Euler)
    // Transform ������Ʈ�� Rotation ���� �� ���� ����(Degree)�� �����Ǿ� ����
    // 3���� �࿡ ���� ȸ�������� ǥ���� ���� ���Ϸ� ���̶�� ����
    // �� ���Ϸ� ���� ���� ��ġ�� ��Ȳ���� ���� 3���� �ƴ� 2������ ���� ���ɼ��� ���� (������ ����)

    // z -> x -> z ������ ���Ϸ����� ó���Ϸ� ��
    // Rx =   1       0       0
    //        0      cos    -sin
    //        0      sin     cos
    // Rz =  cos    -sin      0
    //       sin     cos      0
    //        0       0       1

    // Rz Rx Rz =   cos    -sin      0      1       0       0       cos   -sin    0
    //              sin     cos      0      0      cos    -sin      sin   cos     0
    //               0       0       1      0      sin     cos       0     0      1
    // ���Ϸ� ���� ���� a, b, c��� ����

    // ���
    //       cos(a+c)   -sin(a+c)   0
    //       sin(a+c)    cos(a+c)   0
    //          0           0       1
    // �� �̵��� �����ϸ鼭 ��ġ�� ������ �߻� �ϰ� ��

    // Lerp(a, b, t) �Լ��� t�� ���� ����ϴ� �Լ�
    // a�������� b�������� t�������� �ε巴�� �̵�
    float LerpT() => (Mathf.Sin(time) + 1) * 0.5f;

}
