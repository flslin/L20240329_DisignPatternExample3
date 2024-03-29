using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigonometry : MonoBehaviour
{
    // ���� ���п��� �ٷ�� �͵�
    // 1. �ﰢ�Լ�
    // 2. ��ǥ
    // 3. ����
    // 4. ���
    // 5. ����� (���Ϸ�, ������)
    // 6. �

    // 1-1 �ﰢ�Լ�
    // ����(sin A)    a/h
    // -> ������ angle�̶�� �Ҷ� h�� ������ ������ sin�̶�� ����
    // -> h�� ���̿� ������ �˰� �ִٸ� h�� ���� * sin angle�� ���� ������ ���̸� ���� �� �ֽ��ϴ�.
    // (����Ƽ���� ��ǥ���� y)

    // �ڻ���         b/h
    // -> h�� cos angle�� ���� b�� ����ϴ� ���� ����(����Ƽ���� ��ǥ���� x)

    // ź��Ʈ         a/b

    // �ﰢ�Լ� ��� ���� : ���� ������ ����, ��ä�� ������ ����, ������ ��ǥ ���. ������ ���⺤�� ����ϱ�, �� ���� ������ ���� ���(������ ����)

    // ���� (radian) : ȣ����
    // ���а� ���α׷��� �о߿��� ������ ��Ÿ���� ����
    // ��� �� �� ���� ���� ������ �߽����� �������� ���̸�ŭ �� �������� �������� �� �����ϴ� ���� ũ�⸦ 1 �����̶�� ������
    // �Ϲ����� ���� (Degree) �� 60�� == 1 ���� 
    // ������ : �������� ǥ���ϴ°� ���̸� �̿��� ���������� ǥ���ϴ� �ͺ��� ������ (��ǻ�Ͱ�)

    // Mathf.Deg2Rad�� ���� ������ �������� ����

    private void Start()
    {
        float angle = 45; // ����
        // ����Ƽ ���� �����ϴ� �ﰢ�Լ�
        Debug.Log(Mathf.Sin(angle * Mathf.Deg2Rad));
        Debug.Log(Mathf.Cos(angle * Mathf.Deg2Rad));
        Debug.Log(Mathf.Tan(angle * Mathf.Deg2Rad));
        // ����Ƽ���� �� sin, cos �Լ����� h�� ���� 1�� �����Ǿ�����
        // ���� Sin, Cos�� ������ ����

        Vector2 vector2;
        vector2.x = Mathf.Cos(angle * Mathf.Deg2Rad);
        vector2.y = Mathf.Sin(angle * Mathf.Deg2Rad);

        // x�� �ﰢ���� �غ�(a), y�� �ﰢ���� ����(b)
        // ���� ������ 1�̰� ������ 45���� �ﰢ���� �������� ��ġ�� �ľ��� ����

    }

    private void Update()
    {
        //Vector2 vector2;
        //vector2.x = Mathf.Cos(Time.time * 180 * Mathf.Deg2Rad);
        //vector2.y = Mathf.Sin(Time.time * 180 * Mathf.Deg2Rad);
        //transform.position = vector2;

    }

}
