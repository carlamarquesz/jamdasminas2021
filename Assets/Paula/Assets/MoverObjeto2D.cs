using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//requer um boxCollider2D
[RequireComponent(typeof(Rigidbody2D))]
public class MoverObjeto2D : MonoBehaviour //funciona apenas com cameras ortográficas
{
	Vector3 posicInicial;
	Vector3 posicDestino;
	Vector3 vetorDirecao;
	Rigidbody2D _rigidbody2D;
	bool estaArrastando;
	float distancia;
	[HideInInspector]
	public bool estaConectado;
	[Range(1, 15)]
	public float velocidadeMovimento = 10;
	[Space(10)]
	public Transform conector;
	[Range(0.1f, 2.9f)]
	public float distanciaMinimaConector = 0.5f;
	public MoverObjeto2D instance;
	public bool tocou;

	public AudioSource choque;
	// Start is called before the first frame update
	void Start()
	{
		_rigidbody2D = transform.root.GetComponent<Rigidbody2D> ();  
		instance = this;
		choque = GetComponent<AudioSource>();
	}
	// Update is called once per frame
	void OnMouseDown()
	{
		posicInicial = transform.root.position - Camera.main.ScreenToWorldPoint (Input.mousePosition);  
		_rigidbody2D.gravityScale = 0;
		estaArrastando = true;
		estaConectado = false;
	}
	void OnMouseDrag ()
	{
		posicDestino = posicInicial + Camera.main.ScreenToWorldPoint (Input.mousePosition);
		vetorDirecao = posicDestino - transform.root.position;
		_rigidbody2D.velocity = vetorDirecao * velocidadeMovimento;
	}
	void OnMouseUp()
	{
		_rigidbody2D.gravityScale = 1;
		estaArrastando = false;
	}

    void FixedUpdate ()
	{
		
		if (estaConectado == true && tocou == false)
        {
			//choque.Play();
			tocou = true;
        }
		if(!estaArrastando && !estaConectado) {
			distancia = Vector2.Distance(transform.root.position, conector.position);
			if (distancia < distanciaMinimaConector) {
				_rigidbody2D.gravityScale = 0;
				_rigidbody2D.velocity = Vector2.zero;
				transform.root.position = Vector2.MoveTowards (transform.root.position, conector.position, 0.02f);
			}
			if (distancia < 0.01f){
				instance.estaConectado = true;
				
				transform.root.position = conector.position;
			}

        }
        else
        {
			instance.estaConectado = false;
        }
		
	}
}