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
        // 원으로 펼쳐줄 탄 갯수만큼 반복진행
        for (int i = 0; i < 100; i++)
        {
            var bullet = Instantiate(BulletPrefab);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = Quaternion.identity;

            Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
            // 원 운동을 위한 방향값 계산
            // x, y 좌료에 대한 값 계산 x -> Cos, y -> Sin
            Vector2 direction = new Vector2((Mathf.Cos(Mathf.PI) * 2 * i / 100), Mathf.Sin(Mathf.PI * 2 * i / 100));
            rbody.AddForce(direction.normalized * 2.0f, ForceMode2D.Impulse);

            // 문제 - AddForce가 힘을 가해주지만, 발사 각도에 따라 회전 값 적용이 안되서 각도는 다른데 힘이 가해지는 위치가 같아 같은 방향으로 이동되는 현상 발생

            Vector3 rotation = (Vector3.forward * 360 * i / 100) + Vector3.forward * 90;
        }
    }

}
