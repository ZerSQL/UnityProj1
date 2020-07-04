using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject applePrefab;

    
    //public float speed = 20f;
    //public float leftAndRightEdge = 10f;
    //public float chanceToChangeDirections = 0.1f;
    //public float secondsBetweenAppleDrops = 2.0f;

    void Start()
    {
        StartCoroutine(Spawn());
    }

  

    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(applePrefab, new Vector2(Random.Range(-25f, 25f), 14.2f), Quaternion.identity);
            yield return new WaitForSeconds (1f);
        }
    }
}
//void Start()
//{
//    Invoke("DropApple", 0.3f);
//}

//void DropApple()
//{
//    GameObject apple = Instantiate<GameObject>(applePrefab);
//    apple.transform.position = transform.position;
//    Invoke("DropApple", secondsBetweenAppleDrops);
//}

//    void Update()
//    {
//        Vector3 pos = transform.position;
//        pos.x += speed * Time.deltaTime;
//        transform.position = pos;
//        if (pos.x < -leftAndRightEdge)
//        {
//            speed = Mathf.Abs(speed);
//        }
//        else if (pos.x > leftAndRightEdge)
//        {
//            speed = -Mathf.Abs(speed);
//        }



//    }
//    void FixedUpdate()
//    {
//       if ( Random.value < chanceToChangeDirections)
//        {
//            speed *= -1;
//        }
//    }


//    public void SChangeSpeed()
//    {
//        speed *= 2f;
//    }
//}
