using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Volver : MonoBehaviour, IPointerDownHandler {

	private bool pausa;
	public Canvas canvas;

	public void OnPointerDown(PointerEventData eventData){

		pausa = false;
		canvas.enabled = pausa;
		Time.timeScale = 1f;

	}
}
