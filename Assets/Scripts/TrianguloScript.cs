using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrianguloScript : MonoBehaviour
{

		Transform player;
		float move;
		public Text textQuestions;
		public Text r1;
		public Text r2;
		public Text r3;
		private string[,] pregunta = new string[3, 4];
	
		// Use this for initialization
		void Start ()
		{

		}
	
		// Update is called once per frame
		void Update ()
		{
				move = -.3f;
				player = GameObject.Find ("Cubito").transform;
				cargarPreguntas ();
				rigidbody2D.velocity = new Vector2 (move, 0);
		}

		void OnCollisionEnter2D (Collision2D  coll)
		{
				if (coll.gameObject.tag == "Player") {	
						int i = Random.Range (0, 3);
						Destroy (this.gameObject, 0.5f);
						textQuestions.text = pregunta [i, 0];
						r1.text = pregunta [i, 1];
						r2.text = pregunta [i, 2];
						r3.text = pregunta [i, 3];
			
				}
		
		}
	
		void cargarPreguntas ()
		{
		
				pregunta [0, 0] = "¿A que figura corresponde este enemigo?";
				pregunta [0, 1] = "Trieangulo";
				pregunta [0, 2] = "Rombo";
				pregunta [0, 3] = "Circulo";
				pregunta [1, 0] = "¿Cual es la formula del area de un triangulo?";
				pregunta [1, 1] = "Pi*radio^2 ";
				pregunta [1, 2] = "Lado*Lado";
				pregunta [1, 3] = "(Base * Altura)/2";
				pregunta [2, 0] = "¿Cual es la formula del perimetro de un circulo?";
				pregunta [2, 1] = "Pi*radio^2";
				pregunta [2, 2] = "Sumar los 3 lados";
				pregunta [2, 3] = "Lado*4";
		}
}
