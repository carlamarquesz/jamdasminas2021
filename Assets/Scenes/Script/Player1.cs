using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.Rendering.Universal;
public class Player1 : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Vector2 moveInput;
    public Animator animator;
    public Light2D luz;
    public GameObject luzsala;
    public GameObject Confete;
    // Start is called before the first frame update
    void Start()
    {
        if(GameData.voltapuzzle == true)
        {
            luz.intensity = 0;
            transform.position = GameData.playerPosition;

        }   
        else
        {
            transform.position = new Vector3(3, -4, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {


        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.Translate(moveInput * Time.deltaTime * moveSpeed);
        animator.SetFloat("horizontal", moveInput.x);
        animator.SetFloat("vertical", moveInput.y);
        animator.SetFloat("velocidade", moveInput.sqrMagnitude);

        if(moveInput != Vector2.zero)
        {
            animator.SetFloat("horizontalidle", moveInput.x);
            animator.SetFloat("verticalidle", moveInput.y);

        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Porta")
        {
            if(GameData.acabou == true)
            {
                GameController.instance.caixadialogo10();
                Confete.SetActive(true);
                StartCoroutine(apagandoluz());  
                //GameController.instance.Pause();
                
            }
            else
            {
                GameController.instance.caixadedialogo();
            }
            


        }
        IEnumerator apagandoluz()
        {

            while (luzsala.GetComponent<Light2D>().intensity > 0)
            {
                yield return new WaitForSeconds(1);
                luzsala.GetComponent<Light2D>().intensity = luzsala.GetComponent<Light2D>().intensity - 0.3f;
            }
            yield return new WaitForSeconds(2);
            luz.intensity = 0;
            Confete.SetActive(false);
            Application.Quit();
            GameController.instance.Pause();

        }

        if (collision.gameObject.tag == "MesaPlayer")
        {

            GameController.instance.caixadialogo2();

        }
        if (collision.gameObject.tag == "sofa")
        {

            GameController.instance.caixadialogo3();
            

        }

        if (collision.gameObject.tag == "papeis")
        {

            GameController.instance.caixadialogo4();

        }

        


        if (collision.gameObject.tag == "caixaenergia" && GameData.voltapuzzle == false)
        {
            GameData.playerPosition = transform.position;
            SceneManager.LoadScene("puzzlePaula", LoadSceneMode.Single);
            
        }
        if (collision.gameObject.tag == "mesavanessa")
        {
            if(GameData.voltapuzzlecarta == false && GameData.luzacesa == true && GameData.voltaplataforma == true)
            {
                GameController.instance.caixadialogo6();
                GameData.playerPosition = transform.position;
               
            }
            if(GameData.luzacesa == false)
            {
                Debug.Log("muito escuro");

            }
            

        }

        if (collision.gameObject.tag == "mesa5")
        {
            if (GameData.senha == false && GameData.luzacesa == true && GameData.voltapuzzlecarta == true)
            {
                GameController.instance.caixadialogo7();
                GameData.playerPosition = transform.position;

            }
            if (GameData.luzacesa == false)
            {
                Debug.Log("muito escuro");

            }


        }
        if (collision.gameObject.tag == "pc")
        {
            if (GameData.luzacesa == true && GameData.voltaplataforma == false)
            {
                GameController.instance.caixadialogo8();
                GameData.playerPosition = transform.position;
                

            }
            if (GameData.luzacesa == false)
            {
                Debug.Log("muito escuro");

            }


        }


    }
}
