using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class não : MonoBehaviour
{
    public AudioSource click;
    public void OnMouseDown()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        cena2.nao = true;
    }
}
