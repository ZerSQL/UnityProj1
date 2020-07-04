using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public bool dirRight = true;
    public float speed = 5.0f;
    public GameObject windPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateWind());
    }

    // Update is called once per frame
    void Update()
    {
        //if (dirRight)
        //    transform.Translate(Vector2.right * speed * Time.deltaTime);
        //else
        //    transform.Translate(-Vector2.right * speed * Time.deltaTime);
        //if (transform.position.x >= 66f){
        //    dirRight = false;
        //}
        //if(transform.position.x <= -66f)
        //{
        //    dirRight = true;
            

        //}
    }

    IEnumerator GenerateWind()
    {
        float spawnTime;
        yield return new WaitForSeconds(10.0f);
        while (true)
        {
            spawnTime = Random.Range(10.0f, 20.0f);
            
            Instantiate(windPrefab, new Vector3(-66f, 1f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
