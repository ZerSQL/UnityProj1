using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLemon : MonoBehaviour
{
    public GameObject lemon;

    void Start()
    {
        StartCoroutine(SpawnLem());       
    }

    IEnumerator SpawnLem()
    {
        while (true)
        {
            Instantiate(lemon, new Vector2(Random.Range(-29f, 29f), 14f), Quaternion.identity);
            yield return new WaitForSeconds(1.1f);
        }
    }
}
