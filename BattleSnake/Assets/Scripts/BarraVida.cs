using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraVida : MonoBehaviour {

	public Scrollbar HealthBar;
	public static float Health = 100f;
	public static float value = 0.5f;


	void Update(){

		Health = Health;
		HealthBar.size = Health / 100f;

	}

	void OnTriggerStay2D(Collider2D col){
	
		Health -= value;
		HealthBar.size = Health / 100f;

	}

}
