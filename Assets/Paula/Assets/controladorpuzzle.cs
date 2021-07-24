using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controladorpuzzle : MonoBehaviour
{
    public GameObject conectorVermelho;
    public GameObject bateriaVermelha;
    public GameObject conectorAzul;
    public GameObject bateriaAzul;
    public GameObject conectorVerde;
    public GameObject bateriaVerde;
    public GameObject conectorLaranja;
    public GameObject bateriaLaranja;

   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(conectorVermelho.transform.position == bateriaVermelha.transform.position &&
           conectorAzul.transform.position == bateriaAzul.transform.position &&
           conectorVerde.transform.position == bateriaVerde.transform.position &&
           conectorLaranja.transform.position == bateriaLaranja.transform.position )
        {
            GameData.voltapuzzle = true;
            GameData.luzacesa = true;
            SceneManager.LoadScene("Cena1", LoadSceneMode.Single);
            

        }
        else
        {
            GameData.voltapuzzle = false;
            GameData.luzacesa = false;
        }
    }
}
