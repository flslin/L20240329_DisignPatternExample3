using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPool : MonoBehaviour
{
    // [무한 생성기의 경우]
    // 1. Update 문으로 구현
    // 2. Coroutine을 이용한 설계

    public GameObject monsterPrefab; // 몬스터 프리팹에 대한 값
    public int poolSize; // 풀로 생성할 유닛의 개수
    public float spawnTime; // 몬스터의 젠(생성) 시간
    GameObject[] monsterPool; // 몬스터에 대한 배열 (몬스터 풀)

    GameObject monsterSpawnPool; // 풀을 관리할 오브젝트

    void Start()
    {
        monsterSpawnPool = new GameObject("MonsterSpawnPool");

        monsterPool = new GameObject[poolSize]; // 풀에서 설정된 사이즈만큼 할당

        Spawn(monsterPool, poolSize); // 할당한 배열만큼 생성 진행

        StartCoroutine("MonsterPooling"); // 특정시간마다 몬스터가 생성될 수 있도록 코루틴 작동
    }

    private void Spawn(GameObject[] monsterPool, int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            monsterPool[i] = Instantiate(monsterPrefab); // 몬스터 프리팹 생성
            monsterPool[i].name = "Monster_" + i; // 생성 몬스터 이름 지정
            monsterPool[i].transform.parent = monsterSpawnPool.transform; // 풀을 부모로 등록
            
            monsterPool[i].SetActive(false); // 비활성화 처리
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
                float y = Random.Range(-5, 5); // 3D로 생성을 하는 경우 x, z축으로 설계

                monsterPool[i].transform.position = new Vector2(x, y); // 3D일 경우 Vector3

                monsterPool[i].SetActive(true); // 활성화
                break;
            }
        }
    }
}
