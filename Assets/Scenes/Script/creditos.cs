using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditos : MonoBehaviour
{
    public GameObject canvascredito;
    public AudioSource click;
    public void btn_credito()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        canvascredito.SetActive(true);
    }

   

}
