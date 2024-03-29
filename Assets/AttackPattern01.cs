using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPattern01 : MonoBehaviour
{
    // ��ä�� ��� �߻� ���
    public GameObject BulletPrefab;

    private void Start()
    {
    }

    private void Update()
    {
        FireSector();
    }

    int count = 0;

    private void FireSector()
    {
        var bullet = Instantiate(BulletPrefab);

        Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
        Vector2 dir = new Vector2(Mathf.Cos(Mathf.PI * count), -1);
        rbody.AddForce(dir.normalized * 3, ForceMode2D.Impulse); // normalized�� ���� ����ȭ ���� ForceMode2D.Impulse�� ���� ���������� ���� ����
        count++;
    }
}
