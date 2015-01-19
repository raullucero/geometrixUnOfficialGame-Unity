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
		private string pregunta = "¿A que figura corresponde este enemigo?";
		private string respuesta1 = "Cuadrado";
		private string respuesta2 = "Rombo";
		private string respuesta3 = "Circulo";
		
		// Use this for initialization
		void Start ()
		{
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
						Destroy (this.gameObject, 0.5f);
						textQuestions.text = pregunta;
						r1.text = respuesta1;
						r2.text = respuesta2;
						r3.text = respuesta3;
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
}
