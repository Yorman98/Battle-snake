using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Controlador : MonoBehaviour {

	public void CambiarEscena(string nombre){
		print("Cambiando Escena"+nombre);
		SceneManager.LoadScene(nombre);
		
	}

	public void Salir(){
		print("Saliendo del Juego");
		Application.Quit();
	}
}
