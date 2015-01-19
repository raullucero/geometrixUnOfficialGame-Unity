using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class RectanguloScript : MonoBehaviour {

	public Text textQuestions;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D  coll)
	{
		if (coll.gameObject.tag == "Player") {	
			Destroy (this.gameObject, 0.5f);
			textQuestions.text = "me tocaste";	
			
		}
		
	}
}
