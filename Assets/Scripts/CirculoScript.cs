using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CirculoScript : MonoBehaviour
{

		bool facingRight = true;
		int direction;
		float move;
		Animator anim;
		public Text textQuestions;
		public Text r1;
		public Text r2;
		public Text r3;
		private string[,] pregunta = new string[3, 4];
		

		
		// Use this for initialization
		void Start ()
		{
				cargarPreguntas ();
				anim = GetComponent<Animator> ();
				move = -4f;

		}
	
		// Update is called once per frame
		void Update ()
		{

				//Debug.Log (transform.position.x+ " " +transform.position.y);
				if (transform.position.x > 10.6f && transform.position.x < 10.8f) {
						move *= -1;
						Flip ();
						Debug.Log ("Cambio hacia derecha");
			
				} else if (transform.position.x > 31.5 && transform.position.x < 31.7f) {
						move *= -1;
						Flip ();
						Debug.Log ("Cambio hacia derecha");
				}

				
		}

		void FixedUpdate ()
		{
		
				anim.SetFloat ("Speed", Mathf.Abs (move));
				rigidbody2D.velocity = new Vector2 (move, rigidbody2D.velocity.y);

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
						anim.SetBool ("Destroy", true);
				}
		
		}
	
		void Flip ()
		{
				facingRight = !facingRight;
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
		}

		void cargarPreguntas ()
		{
				
				pregunta [0, 0] = "¿A que figura corresponde este enemigo?";
				pregunta [0, 1] = "Cuadrado";
				pregunta [0, 2] = "Rombo";
				pregunta [0, 3] = "Circulo";
				pregunta [1, 0] = "¿Cual es la formula del area del circulo?";
				pregunta [1, 1] = "Pi*radio^2 ";
				pregunta [1, 2] = "Lado*Lado";
				pregunta [1, 3] = "Base * Altura";
				pregunta [2, 0] = "¿Cual es la formula del perimetro de un circulo?";
				pregunta [2, 1] = "Pi*radio^2";
				pregunta [2, 2] = "Pi*diametro";
				pregunta [2, 3] = "Lado*4";
		}


}
