using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ValidadordeRespuesta : MonoBehaviour
{

		private GameObject figura;
		public Text pregunta;
		public GameObject menu;

		void Start ()
		{
				figura = GameObject.Find ("Cubito");
		}
		

		// Update is called once per frame
		public void selectRespuesta1 ()
		{
				// cuando preciona un boton se reestablece el tiempo 
				//Time.timeScale = 1.0f;
				CubitoScript playerScript = figura.GetComponent<CubitoScript> ();

				if (playerScript.Figura == "EnemyCirculo" && pregunta.text == "¿Cual es la formula del area del circulo?") {
						menu.SetActive (false);
						Time.timeScale = 1.0f;
						Debug.Log ("correcto");		
				} else if (playerScript.Figura == "EnemyTriangulo" && pregunta.text == "¿A que figura corresponde este enemigo?") {
						Debug.Log ("correcto");	
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else if (playerScript.Figura == "EnemyPentagono" && pregunta.text == "¿Cual es la formula del perimetro del pentagono?") {
						Debug.Log ("correcto");	
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else {
						Debug.Log ("you die");
						Time.timeScale = 1.0f;
						menu.SetActive (false);
						Destroy (GameObject.Find ("Cubito"), 0.5f);
				}

		}

		public void selectRespuesta2 ()
		{
				CubitoScript playerScript = figura.GetComponent<CubitoScript> ();
				if (playerScript.Figura == "EnemyCirculo" && pregunta.text == "¿Cual es la formula del perimetro de un circulo?") {
						Debug.Log ("correcto");	
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else if (playerScript.Figura == "EnemyTriangulo" && pregunta.text == "¿Cual es la formula del perimetro de un triangulo?") {
						Debug.Log ("correcto");	
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else if (playerScript.Figura == "EnemyPentagono" && pregunta.text == "¿A que figura corresponde este enemigo?") {
						Debug.Log ("correcto");	
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else if (playerScript.Figura == "EnemyPentagono" && pregunta.text == "¿Cual es la formula del area del pentagono?") {
						Debug.Log ("correcto");
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else if (playerScript.Figura == "EnemyRectangulo" && pregunta.text == "¿Cual es la formula del area del rectangulo?") {
						Debug.Log ("correcto");
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else if (playerScript.Figura == "EnemyRectangulo" && pregunta.text == "¿Cual es la formula del perimetro del rectangulo?") {
						Debug.Log ("correcto");	
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else {
						Debug.Log ("you die");
						Time.timeScale = 1.0f;
						menu.SetActive (false);
						Destroy (GameObject.Find ("Cubito"), 0.5f);
				}
	
		}

		public void selectRespuesta3 ()
		{
				CubitoScript playerScript = figura.GetComponent<CubitoScript> ();

				if (playerScript.Figura == "EnemyCirculo" && pregunta.text == "¿A que figura corresponde este enemigo?") {
						Debug.Log ("correcto");	
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else if (playerScript.Figura == "EnemyRectangulo" && pregunta.text == "¿A que figura corresponde este enemigo?") {
						Debug.Log ("correcto");
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else if (playerScript.Figura == "EnemyTriangulo" && pregunta.text == "¿Cual es la formula del area de un triangulo?") {
						Debug.Log ("correcto");	
						menu.SetActive (false);
						Time.timeScale = 1.0f;
				} else {
						Debug.Log ("you die");
						Time.timeScale = 1.0f;	
						menu.SetActive (false);
						Destroy (GameObject.Find ("Cubito"), 0.5f);
				}

						

		}
}
