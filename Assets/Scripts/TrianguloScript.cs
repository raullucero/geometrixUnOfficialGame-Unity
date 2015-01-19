using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrianguloScript : MonoBehaviour
{

		Transform player;
		float move;
		public Text textQuestions;

		// Use this for initialization
		void Start ()
		{

		}
	
		// Update is called once per frame
		void Update ()
		{
				move = -.3f;
				player = GameObject.Find ("Cubito").transform;

				rigidbody2D.velocity = new Vector2 (move, move);
		}

		void OnCollisionEnter2D (Collision2D  coll)
		{
				if (coll.gameObject.tag == "Player") {	
						Destroy (this.gameObject, 0.5f);
						textQuestions.text = "me tocaste";	

				}
		
		}
}
