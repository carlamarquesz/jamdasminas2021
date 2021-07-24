using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sim : MonoBehaviour
{
    public AudioSource click;
    public void OnMouseDown()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        cena2.sim = true;
    }
}
