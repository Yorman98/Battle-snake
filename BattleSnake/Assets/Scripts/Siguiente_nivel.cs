using UnityEngine;
using System.Collections;

public class Siguiente_nivel : MonoBehaviour {

	public GameObject enemigo;
	private string nivel = "nivel_";
	private int num;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

		enemigo = GameObject.FindGameObjectWithTag("Enemigo");

		if (BarraVida.Health <= 0) {
			Application.LoadLevel ("Portada");
			BarraVida.Health = 100;
			Disparar.nivel = 1;
		}
			

		if (enemigo == null) {

			Disparar.nivel += 1;

			if (Disparar.nivel > 5){
					nivel = "Portada";
					BarraVida.Health = 100;
			Disparar.nivel = 1;

			}else
				nivel = nivel + Disparar.nivel.ToString ();
			
			Application.LoadLevel (nivel);
		}
			

	}

}
