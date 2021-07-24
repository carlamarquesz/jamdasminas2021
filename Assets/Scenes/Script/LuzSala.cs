using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;



public class LuzSala : MonoBehaviour
{
    public GameObject canvascaixaenergia;
    public GameObject canvascaixaenergia2;
    public GameObject canvascaixaenergia3;
    public GameObject canvasvanessa;
    public GameObject canvasposvanessa;
    public GameObject canvasposvanessa2;

    public  Light2D luz;

   
    // Start is called before the first frame update
    void Start()
    {
        
        if (GameData.luzacesa == true)
        {
            if(GameData.voltapuzzlecarta == false && GameData.voltaplataforma == false)
            {
                StartCoroutine(ligandoluz());
            }
            if (GameData.voltapuzzlecarta == true && GameData.canvaspuzzlecarta==false) 
            {
                luz.GetComponent<Light2D>().color = Color.white;
                luz.GetComponent<Light2D>().intensity = 1;
                canvasposvanessa.SetActive(true);
                GameData.canvaspuzzlecarta = true;
                GameController.instance.Pause();
                
            }
            if(GameData.voltaplataforma == true && GameData.canvasplataforma == false)
            {
                luz.GetComponent<Light2D>().color = Color.white;
                luz.GetComponent<Light2D>().intensity = 1;
            }
            
        }
    }
    IEnumerator ligandoluz()
    {
        luz.GetComponent<Light2D>().color = Color.white;
        yield return new WaitForSeconds(1);
        luz.GetComponent<Light2D>().intensity = 1;
        if(GameData.voltapuzzlecarta == false)
        {
            canvascaixaenergia.SetActive(true);
        }
        
        GameController.instance.Pause();

    }
    

    public void OnMouseDown()
    {

        canvascaixaenergia.SetActive(false);
        canvascaixaenergia2.SetActive(true);
        GameController.instance.Pause();


    }

    public void OnMouseDown2()
    {

        canvascaixaenergia2.SetActive(false);
        canvascaixaenergia3.SetActive(true);
        GameController.instance.Pause();

    }

    public void OnMouseDown3()
    {

        canvascaixaenergia3.SetActive(false);
        GameController.instance.unPause();


    }
    
   

    public void OnMouseDown6()
    {


        canvasposvanessa.SetActive(false);
        canvasposvanessa2.SetActive(true);
        


    }

    public void OnMouseDown7()
    {


        canvasposvanessa2.SetActive(false);
        GameController.instance.unPause();



    }
    





}