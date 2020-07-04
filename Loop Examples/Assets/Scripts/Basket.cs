using UnityEngine;
using UnityEngine.UI;


public class Basket : MonoBehaviour
{
    public Transform basket;
    [Header("Set Dynamically")]
   
    [SerializeField]
    [System.Obsolete]
    public Text scoreGT;
    private float speed = 60f;
    public AudioSource apple;
    public AudioSource lemon;

   
    private int numApple;

    [System.Obsolete]
    void Start()
    {
        
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();

        scoreGT.text = "0";

    }
    void Update()
    {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 25f ? 25f : mousePos.x;
            mousePos.x = mousePos.x < -25f ? -25f : mousePos.x;
            basket.position = Vector2.MoveTowards(basket.position, new Vector2(mousePos.x, basket.position.y), speed * Time.deltaTime);
        
        
    }

    [System.Obsolete]
    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
     int score = int.Parse(scoreGT.text);
      
        if (collidedWith.tag == "Apple")
        {
        
            apple.pitch = Random.Range(0.9f, 1.1f);
            apple.Play();
            Destroy(collidedWith);
            score += 1;

            if (score == 50)
            {


            }
            scoreGT.text = score.ToString();
            
        }

        if (collidedWith.tag == "Lemon")
            {
            lemon.pitch = Random.Range(0.9f, 1.1f);
            lemon.Play();
                Destroy(collidedWith);
            score = score - 5;
        }
        if (score <= -1)
        {
            score = 0;
        }
        scoreGT.text = score.ToString();
    }
    }



