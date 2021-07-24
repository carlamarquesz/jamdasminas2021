using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Apple : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public AudioSource sompegar;

    public GameObject collected;
    public int Score; 


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>(); 

    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.gameObject.tag == "Player2")
        {  
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            GameController2.instance.totalScore += Score;
            if(SceneManager.GetActiveScene().name == "Lvl_2")
            {
                sompegar.Play();
                PlataformaData.chave2++;


            }
            else
            {
                if(SceneManager.GetActiveScene().name == "Lvl_5")
                {
                    sompegar.Play();
                    PlataformaData.chave5++;
                }
            }
            GameController2.instance.UpdateScoreText();

            Destroy(gameObject, 0.5f);  
        }
    }
}
