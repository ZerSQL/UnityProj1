using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    [System.Obsolete]
    void Update()
    {
        GUIText gt = this.GetComponent<GUIText>();
        gt.text = "High Score: " + score;
    }
}
