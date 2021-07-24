using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class voltar : MonoBehaviour
{
    public GameObject canvascredito;

    public AudioSource click;
    public void btn_voltar()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        canvascredito.SetActive(false);
    }

    
}
