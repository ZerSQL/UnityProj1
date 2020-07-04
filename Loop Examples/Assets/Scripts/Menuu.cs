using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void back()
    {

        SceneManager.LoadScene("sc");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
