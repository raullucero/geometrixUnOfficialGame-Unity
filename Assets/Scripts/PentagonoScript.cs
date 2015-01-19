using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PentagonoScript : MonoBehaviour
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
				anim = GetComponent<Animator> ();		
				cargarPreguntas ();
		
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{
				move = .7f;
				anim.SetFloat ("Speed", Mathf.Abs (move));
				rigidbody2D.velocity = new Vector2 (move, rigidbody2D.velocity.y);
				
		
				if (move > 0 && !facingRight) 
						Flip ();
				else if (move < 0 && facingRight) 
						Flip ();

	
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
				pregunta [0, 2] = "Pentagono";
				pregunta [0, 3] = "Circulo";
				pregunta [1, 0] = "¿Cual es la formula del area del pentagono?";
				pregunta [1, 1] = "Pi*radio^2 ";
				pregunta [1, 2] = "(Perimetro*Apotema)/2 ";
				pregunta [1, 3] = "Base * Altura";
				pregunta [2, 0] = "¿Cual es la formula del perimetro del pentagono?";
				pregunta [2, 1] = "Lado*5";
				pregunta [2, 2] = "Pi*diametro";
				pregunta [2, 3] = "Pi*radio^2";
		}
	
}
