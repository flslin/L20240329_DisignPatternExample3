using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPattern02 : MonoBehaviour
{
    public GameObject BulletPrefab;

    void Start()
    {
        Pattern02();
    }

    private void Update()
    {
    }

    void Pattern02()
    { 
        // ������ ������ ź ������ŭ �ݺ�����
        for (int i = 0; i < 100; i++)
        {
            var bullet = Instantiate(BulletPrefab);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = Quaternion.identity;

            Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
            // �� ��� ���� ���Ⱚ ���
            // x, y �·ῡ ���� �� ��� x -> Cos, y -> Sin
            Vector2 direction = new Vector2((Mathf.Cos(Mathf.PI) * 2 * i / 100), Mathf.Sin(Mathf.PI * 2 * i / 100));
            rbody.AddForce(direction.normalized * 2.0f, ForceMode2D.Impulse);

            // ���� - AddForce�� ���� ����������, �߻� ������ ���� ȸ�� �� ������ �ȵǼ� ������ �ٸ��� ���� �������� ��ġ�� ���� ���� �������� �̵��Ǵ� ���� �߻�

            Vector3 rotation = (Vector3.forward * 360 * i / 100) + Vector3.forward * 90;
        }
    }

}
