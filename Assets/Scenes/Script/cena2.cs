using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cena2 : MonoBehaviour
{
    public static bool sim;
    public static bool nao = false;
    public  GameObject canvasemail;
    public GameObject canvasdemite;
    public AudioSource click;
    // public AudioClip click;
    // Start is called before the first frame update
    void Start()
    {
       click =  GetComponent<AudioSource>();
    }
    public void restart()
    {
        nao = false;
        SceneManager.LoadScene("Cena3", LoadSceneMode.Single);
    }
    public void fecharemail()
    {
        click.Play();
        Debug.Log("fecharemail");
        canvasemail.SetActive(false);
        sim = false;
    }
    public void aceitaremail()
    {
        
        Debug.Log("aceitaremail");
        SceneManager.LoadScene("Cena1", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        if(sim == true)
        {
            canvasemail.SetActive(true);
        }
        else
        {
            canvasemail.SetActive(false);
        }
        if(nao == true)
        {
            canvasdemite.SetActive(true);
        }
        else
        {
            canvasdemite.SetActive(false);
        }
    }
}
