using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Nuevo_juego : MonoBehaviour, IPointerDownHandler {

	public void OnPointerDown(PointerEventData eventData){

		Application.LoadLevel ("Portada");
		Time.timeScale = 1;
		BarraVida.Health = 100f;
		Disparar.nivel = 1;

	}
}
