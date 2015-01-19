using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public void changeScene (){
		Application.LoadLevel ("Scene Geometrix");
	}	

	public void Exit ()
	{
		Application.Quit();
	}
}
