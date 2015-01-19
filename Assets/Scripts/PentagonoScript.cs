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

		// Use this for initialization
		void Start ()
		{
				anim = GetComponent<Animator> ();		
		
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
						Destroy (this.gameObject, 0.5f);
						textQuestions.text = "me tocaste";	

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
