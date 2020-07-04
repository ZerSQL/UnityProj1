using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using UnityEngine.Advertisements;
public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject Heart;
    public int numBaskets = 3;
    public float basketBottomY = -6f;
    public float basketSpacingX = 2f;
    public float basketBottomX = 9f;
    public List<GameObject> basketList;

    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3410389", false);
        }
        else Debug.Log("Platform is not supported");
        basketList = new List<GameObject>();

        for (int i = 0; i < numBaskets; i++)
        {

            GameObject tBasketGO = Instantiate<GameObject>(Heart);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY;
            pos.x = basketBottomX + basketSpacingX * i;
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);

        }
        basketList.Reverse();
    }





    public void AppleDestroyed()
    {

        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");


        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        int basketIndex = basketList.Count - 1;

        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);
        if (basketList.Count == 0)
        {
            if (Advertisement.IsReady())
            {
                Debug.Log("Ads");
                Advertisement.Show();
            }

            SceneManager.LoadScene("Death");

        }

    }
     }
