using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController2 : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public GameObject gameOver;
    public GameObject musica;

    public static GameController2 instance; 

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Lvl_2")
        {
            musica.GetComponent<AudioSource>().Play();
        }
        instance = this;
        PlataformaData.chave2 = 0;
        PlataformaData.chave5 = 0;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString(); 


    }
    
    public void ShowGameOver()
    {
        Destroy(GameObject.FindGameObjectWithTag("musicaplataforma"));
        gameOver.SetActive(true); 
    }

    public void OnMouseUp()
    {
        gameOver.SetActive(true);
        SceneManager.LoadScene("Lvl_2", LoadSceneMode.Single);
    }
    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Lvl_2" && PlataformaData.chave2 == 4)
        {
            SceneManager.LoadScene("Lvl_5");
        }
        else if(PlataformaData.chave5 == 5)
        {
            GameData.voltaplataforma = true;
            GameData.canvasplataforma = false;
            Destroy(GameObject.FindGameObjectWithTag("musicaplataforma"));
            SceneManager.LoadScene("Cena1");
        }
    }
}
