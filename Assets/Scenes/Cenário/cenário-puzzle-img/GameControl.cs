using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    public GameObject canvasbilhete;
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;
    public GameObject conector0;
    public GameObject carta0;
    public GameObject conector1;
    public GameObject carta1;
    public GameObject conector2;
    public GameObject carta2;
    public GameObject conector3;
    public GameObject carta3;
    public GameObject conector4;
    public GameObject carta4;
    public GameObject conector5; 
    public GameObject carta5;
    public GameObject conector6;
    public GameObject carta6;
    public GameObject conector7;
    public GameObject carta7;
    public GameObject conector8;
    public GameObject carta8;
    public GameObject conector9;
    public GameObject carta9;
    public GameObject musica;
    public AudioSource click;

    public GameObject canvasbox;
    public GameObject canvasvoltar;
    // Start is called before the first frame update


    public void boxdica()
    {
        click.Play();
        canvasvoltar.SetActive(true);
        
    }

    public void boxdica2()
    {
        click.Play();
        canvasvoltar.SetActive(false);
        
    }
    void Start()
    {
        canvasbox.SetActive(true);
        winText.SetActive(false);
        musica.GetComponent<AudioSource>().Play();
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pictures[0].rotation.z == 0 &&
           pictures[1].rotation.z == 0 &&
           pictures[2].rotation.z == 0 &&
           pictures[3].rotation.z == 0 &&
           pictures[4].rotation.z == 0 &&
           pictures[5].rotation.z == 0 &&
           pictures[6].rotation.z == 0 &&
           pictures[7].rotation.z == 0 &&
           pictures[8].rotation.z == 0 &&
           pictures[9].rotation.z == 0 &&
           pictures[10].rotation.z == 0 &&
           pictures[11].rotation.z == 0 &&
           conector0.transform.position == carta0.transform.position &&
           conector1.transform.position == carta1.transform.position &&
           conector2.transform.position == carta2.transform.position &&
           conector3.transform.position == carta3.transform.position &&
           conector4.transform.position == carta4.transform.position &&
           conector5.transform.position == carta5.transform.position &&
           conector6.transform.position == carta6.transform.position &&
           conector7.transform.position == carta7.transform.position &&
           conector8.transform.position == carta8.transform.position &&
           conector9.transform.position == carta9.transform.position

           )
        {
            youWin = true;
            winText.SetActive(true);
        }

       

    }

    public void OnMouseDown()
    {

        canvasbilhete.SetActive(true);


    }

    public void OnMouseDown2()
    {

        GameData.voltapuzzlecarta = true;
        SceneManager.LoadScene("Cena1", LoadSceneMode.Single);

    }


}
