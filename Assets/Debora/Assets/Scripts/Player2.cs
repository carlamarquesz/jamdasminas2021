using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public float Speed;
    public float JumpForce;

    public bool jumpkeypressed;
    public bool isJumping;
    public bool doubleJump;

    public AudioSource pulo;

    private Rigidbody2D rig;
    private Animator anim;
   


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")){
            jumpkeypressed = true;
        }
            Jump();
            Move();
         
    }
    private void FixedUpdate()
    {
        if (jumpkeypressed && isJumping == false)
        {
            // IMPORTANT: this prevents the "jump force" from being applied multiple times, while the user holds the Space key
            jumpkeypressed = false;

            /* Remaining jumping logic goes here (AddForce, set "isJumping", etc) */
        }
    }

    void Move() 
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;


        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f); 
        }

        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("walk", false);
        }

    }

    void Jump() 
    {

        if (Input.GetButtonDown("Jump")) 
        {
            jumpkeypressed = true;

            if (!isJumping && jumpkeypressed)
            {
                pulo.Play();
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                doubleJump = true;
                anim.SetBool("jump", true);
            }
            else 
            {
                if(doubleJump && jumpkeypressed) 
                {
                    pulo.Play();
                    rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                    doubleJump = false; 

                }
            }
            
        
        }
    
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.layer == 8) 
        {
            isJumping = false;
            anim.SetBool("jump", false); 
        }

        if(collision.gameObject.tag == "Spike")
        {
            GameController2.instance.ShowGameOver();
            Destroy(gameObject); 
        }


    }

    void OnCollisionExit2D(Collision2D collision) 
    {
        if(collision.gameObject.layer == 8) 
        {
            isJumping = true; 
        
        }
    
    }
}

