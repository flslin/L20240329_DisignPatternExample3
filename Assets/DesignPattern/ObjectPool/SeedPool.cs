using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPool : MonoBehaviour
{
    public GameObject[] seedPrefab;
    GameObject[] seedPool;
    //public Rigidbody2D farmer;
    //public BoxCollider2D farm;

    public int poolSize;
    public float spawnTime = 1.0f;

    //bool isEnter = false;
    //float[] seedPos = new float[4];


    // Start is called before the first frame update
    void Start()
    {
        seedPool = new GameObject[poolSize];
        Spawn(seedPool, poolSize);

        //StartCoroutine("SeedPooling");
    }

    private void Spawn(GameObject[] seedPool, int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            seedPool[i] = seedPrefab[i];
            seedPool[i].name = "Seed_" + i;

            seedPool[i].SetActive(false);
        }

    }

    //IEnumerator SeedPooling()
    //{
    //    while (true)
    //    {

    //        yield return new WaitForSeconds(spawnTime);

    //        for (int i = 0; i < poolSize; i++)
    //        {
    //            if (seedPool[i].activeSelf == true)
    //                continue;

    //            seedPool[i].SetActive(false);
    //            break;
    //        }

    //    }
    //}
}
