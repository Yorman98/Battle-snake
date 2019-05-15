using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Control : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	public bool touch;

	public void OnPointerDown(PointerEventData eventData){

		touch = true;

	}

	public void OnPointerUp(PointerEventData eventData){

		touch = false;

	}


}
