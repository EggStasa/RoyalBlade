using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    public Transform SpawnPos;

    void Start()
    {
        StartCoroutine(SpawnObj());
    }

    void Repeat() {
        StartCoroutine(SpawnObj());
    }

    IEnumerator SpawnObj() {
        yield return new WaitForSeconds(0.5f);
        Instantiate(obj, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
   
}
