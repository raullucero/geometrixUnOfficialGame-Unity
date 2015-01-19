using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class RectanguloScript : MonoBehaviour {

	public Text textQuestions;
	public Text r1;
	public Text r2;
	public Text r3;
	private string[,] pregunta = new string[3, 4];

	// Use this for initialization
	void Start () {
		cargarPreguntas ();
	}
	
	// Update is called once per frame
	void Update () {
	
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
		pregunta [0, 1] = "Cuadrado";
		pregunta [0, 2] = "Rombo";
		pregunta [0, 3] = "Rectangulo";
		pregunta [1, 0] = "¿Cual es la formula del area del rectangulo?";
		pregunta [1, 1] = "Pi*radio^2 ";
		pregunta [1, 2] = "Lado*Lado";
		pregunta [1, 3] = "(Base * Altura)/2";
		pregunta [2, 0] = "¿Cual es la formula del perimetro del rectangulo?";
		pregunta [2, 1] = "Lado*5";
		pregunta [2, 2] = "Sumando sus 4 lados";
		pregunta [2, 3] = "Pi*radio^2";
	}
}
