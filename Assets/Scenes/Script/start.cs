using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class start : MonoBehaviour
{
    public AudioSource som;
    public AudioSource click;

    void Start()
    {
        som = GetComponent<AudioSource>();
        som.Play();
    }
    public void btn_start()
    {
        
        
        click = GetComponent<AudioSource>();
        click.Play();

        SceneManager.LoadScene("Cena2", LoadSceneMode.Single);
    }
}
