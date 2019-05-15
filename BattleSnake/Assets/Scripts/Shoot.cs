using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Shoot : MonoBehaviour , IPointerClickHandler {

	public bool shoot;

	public void OnPointerClick(PointerEventData eventData){
		shoot = true;
	}


}
