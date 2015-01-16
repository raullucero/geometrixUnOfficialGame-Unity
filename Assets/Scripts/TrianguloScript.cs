using UnityEngine;
using System.Collections;

public class TrianguloScript : MonoBehaviour
{

		Transform player;
		float move;

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
}
