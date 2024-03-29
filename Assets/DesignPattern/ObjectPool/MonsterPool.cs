using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPool : MonoBehaviour
{
    // [���� �������� ���]
    // 1. Update ������ ����
    // 2. Coroutine�� �̿��� ����

    public GameObject monsterPrefab; // ���� �����տ� ���� ��
    public int poolSize; // Ǯ�� ������ ������ ����
    public float spawnTime; // ������ ��(����) �ð�
    GameObject[] monsterPool; // ���Ϳ� ���� �迭 (���� Ǯ)

    GameObject monsterSpawnPool; // Ǯ�� ������ ������Ʈ

    void Start()
    {
        monsterSpawnPool = new GameObject("MonsterSpawnPool");

        monsterPool = new GameObject[poolSize]; // Ǯ���� ������ �����ŭ �Ҵ�

        Spawn(monsterPool, poolSize); // �Ҵ��� �迭��ŭ ���� ����

        StartCoroutine("MonsterPooling"); // Ư���ð����� ���Ͱ� ������ �� �ֵ��� �ڷ�ƾ �۵�
    }

    private void Spawn(GameObject[] monsterPool, int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            monsterPool[i] = Instantiate(monsterPrefab); // ���� ������ ����
            monsterPool[i].name = "Monster_" + i; // ���� ���� �̸� ����
            monsterPool[i].transform.parent = monsterSpawnPool.transform; // Ǯ�� �θ�� ���
            
            monsterPool[i].SetActive(false); // ��Ȱ��ȭ ó��
        }
    }

    IEnumerator MonsterPooling()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);

            for(int i = 0; i<poolSize; i++)
            {
                if (monsterPool[i].activeSelf == true)
                    continue;

                float x = Random.Range(-5, 5);
                float y = Random.Range(-5, 5); // 3D�� ������ �ϴ� ��� x, z������ ����

                monsterPool[i].transform.position = new Vector2(x, y); // 3D�� ��� Vector3

                monsterPool[i].SetActive(true); // Ȱ��ȭ
                break;
            }
        }
    }
}
