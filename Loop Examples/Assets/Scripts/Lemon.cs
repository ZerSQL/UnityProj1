using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lemon : MonoBehaviour
{
    public static float bottomY = -14.0f;
    public float fallSpeed = 5f;

    void Update()
    {
        if (transform.position.y < -14f)
            Destroy(gameObject);
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
       
    }
}
