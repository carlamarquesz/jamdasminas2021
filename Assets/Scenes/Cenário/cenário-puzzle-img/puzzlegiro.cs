using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlegiro : MonoBehaviour
{
	Vector3 posicInicial;
	Vector3 posicDestino;
	Vector3 vetorDirecao;
	public AudioSource giro;
	Rigidbody2D _rigidbody2D;
	bool estaArrastando;
	float distancia;
	[HideInInspector]
	public bool estaConectado;
	[Range(1, 15)]
	public float velocidadeMovimento = 10;
	[Space(10)]
	public Transform conector;
	public Transform pos;
	[Range(0.1f, 2.9f)]
	public float distanciaMinimaConector = 0.5f;
	public puzzlegiro instance;
	public bool tocou;

	void Start()
	{
		instance = this;
		_rigidbody2D = transform.root.GetComponent<Rigidbody2D>();
		pos = this.transform;
	}
    void OnMouseUp()
    {
        _rigidbody2D.gravityScale = 0;
        estaArrastando = false;
    }
	void OnMouseDrag()
	{
		if(estaConectado == false){
			posicDestino = posicInicial + Camera.main.ScreenToWorldPoint(Input.mousePosition);
			vetorDirecao = posicDestino - transform.root.position;
			_rigidbody2D.velocity = vetorDirecao * velocidadeMovimento;
		}
		
	}
	void OnMouseDown()
	{

		posicInicial = transform.root.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
		_rigidbody2D.gravityScale = 0;
		estaArrastando = true;
		estaConectado = false;
	}

    private void OnMouseOver()
    {
		if (Input.GetMouseButtonDown(1))
        {
			if (!GameControl.youWin)
			{
				transform.Rotate(0f, 0f, 90f);
				giro.Play();
			}
		}
		
	}
		
    void FixedUpdate()
	{

		//Detect if the middle mouse button is pressed
		
		
		if (estaConectado == true && tocou == false)
		{
			//choque.Play();
			tocou = true;
		}
		if (!estaArrastando && !estaConectado)
		{
			distancia = Vector2.Distance(transform.root.position, conector.position);
			if (distancia < distanciaMinimaConector)
			{
				_rigidbody2D.gravityScale = 0;
				_rigidbody2D.velocity = Vector2.zero;
				transform.root.position = Vector2.MoveTowards(transform.root.position, conector.position, 0.02f);
			}
			if (distancia < 0.1f)
			{
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
