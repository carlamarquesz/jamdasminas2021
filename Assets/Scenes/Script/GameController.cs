using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject canvasporta;
    public GameObject canvasmesa;
    public GameObject canvassofa;
    public GameObject canvaspapeis;
    public GameObject canvascontinuar;
    public GameObject canvasmesa5;
    public GameObject canvasvanessa;
    public GameObject canvasvanessa1;
    public GameObject canvasposmesa5;
    public GameObject canvasfim1;
    public GameObject canvasfim2;
    public GameObject canvasfim3;
    public GameObject canvasfim4;
    public GameObject canvasfim5;
    public GameObject canvasfim6;
    public GameObject canvasfim7;
    public GameObject canvasdica;

    public GameObject canvaspc;
    public GameObject canvaspc2;
    public GameObject canvaspc3;
    public GameObject canvaspc4;
    public GameObject canvaspc5;



    public Light2D luzcaixaenergia;

    public AudioSource energia;
    public AudioSource sofa;
    public AudioSource papeis;
    public AudioSource som;
    public AudioClip click;
    public AudioClip porta;

    public Button continuar;
    public static GameController instance;

   





    void Start()
    {
        instance = this;
        if(GameData.luzacesa == true)
        {
            if (GameData.voltapuzzlecarta == false && GameData.voltaplataforma == false )
            {
                energia.Play();
            }
            if(GameData.voltaplataforma == true && GameData.canvasplataforma == false)
            {
                canvaspc2.SetActive(true);
                GameData.canvasplataforma = true;

            }
            luzcaixaenergia.color = Color.green;

        }
        else
        {
            caixadialogo2();
        }
        som = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void caixadedialogo()
    {
        canvasporta.SetActive(true);
        som.clip = porta;
        som.Play();
        Pause();

    }
    public void caixadialogo2()
    {
        canvasmesa.SetActive(true);
        som.clip = click;
        som.Play();
        Pause();
    }

  

    public void caixadialogo3()
    {
        canvassofa.SetActive(true);
        
        sofa.Play();
        Pause();
    }

    public void caixadialogo4()
    {
        canvaspapeis.SetActive(true);
        papeis.Play();
        Pause();
    }

 
    public void caixadialogo6()
    {
        som.clip = click;
        som.Play();
        canvasvanessa.SetActive(true);
        Pause();
    }

    

    public void caixadialogo8()
    {
        canvaspc.SetActive(true);
        Debug.Log("pc");
        Pause();
    }

    public void caixadialogo9()
    {
        canvaspc2.SetActive(true);
        Pause();
    }


    public void caixadialogo7()
    {
       
        canvasmesa5.SetActive(true);
        Pause();
    }

    public void caixadialogo10()
    {
        som.clip = porta;
        som.Play();
        canvasfim3.SetActive(true);
        Pause();
    }

    public void OnMouseDown24()
    {
        canvasfim3.SetActive(false);
        canvasfim4.SetActive(true);
    }

    public void OnMouseDown25()
    {
        canvasfim4.SetActive(false);
        canvasfim5.SetActive(true);
    }
    public void OnMouseDown26()
    {
        canvasfim5.SetActive(false);
        canvasfim6.SetActive(true);
    }
    public void OnMouseDown27()
    {
        canvasfim6.SetActive(false);
        canvasfim7.SetActive(true);
    }
    public void OnMouseDown28()
    {
        canvasfim7.SetActive(false);
        unPause();
        
    }

    public void OnMouseDown8()
    {
        if(GameData.senhatexto == "2457")
        {
            som.clip = click;
            som.Play();
            canvasmesa5.SetActive(false);
            canvasposmesa5.SetActive(true);
            GameData.acabou = true;
        }
        else
        {
            Debug.Log("senha errada");
        }
        
        
    }
    public void OnMouseDown20()
    {
        canvasmesa5.SetActive(false);
        unPause();


    }

    public void OnMouseDown9()
    {
        som.clip = click;
        som.Play();
        canvasposmesa5.SetActive(false);
        canvasfim1.SetActive(true);
        Pause();
    }

    public void OnMouseDown11()
    {
        som.clip = click;
        som.Play();
        canvasfim1.SetActive(false);
        canvasfim2.SetActive(true);
        Pause();
    }

    public void OnMouseDown12()
    {
        som.clip = click;
        som.Play();
        canvasfim2.SetActive(false);
        
        unPause();
    }

    public void OnMouseDown13()
    {
        som.clip = click;
        som.Play();
        canvasfim3.SetActive(false);
        unPause();
    }

   
    public void OnMouseDown15()
    {
        som.clip = click;
        som.Play();
        canvaspc2.SetActive(false);
        canvaspc3.SetActive(true);
        Pause();
    }
    public void OnMouseDown16()
    {
        som.clip = click;
        som.Play();
        canvaspc3.SetActive(false);
        canvaspc4.SetActive(true);

    }

    public void OnMouseDown21()
    {
        som.clip = click;
        som.Play();
        canvaspc4.SetActive(false);
        canvaspc5.SetActive(true);
        

    }

    public void OnMouseDown22()
    {
        som.clip = click;
        som.Play();
        canvaspc5.SetActive(false);
        unPause();

    }

    public void OnMouseDown17()
    {
        canvaspc.SetActive(false);
        unPause();
        SceneManager.LoadScene("Lvl_2");

    }

    public void OnMouseDown2()
    {
        som.clip = click;
        som.Play();
        canvasmesa5.SetActive(false);
        
    }

    public void OnMouseDown10()
    {
        som.clip = click;
        som.Play();
        canvasvanessa1.SetActive(false);
        unPause();
        SceneManager.LoadScene("Cena5", LoadSceneMode.Single);

    }
    public void OnMouseDown23()
    {
        som.clip = click;
        som.Play();
        canvasvanessa.SetActive(false);
        canvasvanessa1.SetActive(true);
        Pause();
    }

    public void OnMouseDown30()
    {
        som.clip = click;
        som.Play();
        canvasdica.SetActive(true);
        
        Pause();
    }

    public void OnMouseDown31()
    {
        som.clip = click;
        som.Play();
        canvasdica.SetActive(false);
        canvasmesa5.SetActive(true);

    }





    public void OnMouseDown()
    {
        
        if (GameData.luzacesa == false)
        {
            canvasporta.SetActive(false);
            canvascontinuar.SetActive(true);
            som.clip = click;
            som.Play();
            Pause();
        }
        else
        {
            canvasporta.SetActive(false);
            unPause();
        }
       
    }

    
    

    public void Retorno()
    {
        canvaspapeis.SetActive(false);
        canvasporta.SetActive(false);
        canvassofa.SetActive(false);
        canvasmesa.SetActive(false);
        canvascontinuar.SetActive(false);
        som.clip = click;
        som.Play();
        unPause();

    }

    public bool isPause;
    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void unPause()
    {
        Time.timeScale = 1;
    }

   
}
