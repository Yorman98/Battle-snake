using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Pausa : MonoBehaviour, IPointerDownHandler {


	private bool pausa;
	private bool volver;
	public Canvas canvas;
	// Use this for initialization
	void Start () {
		//canvas = GetComponent<Canvas> ();
		canvas.enabled = false;
	}

	public void OnPointerDown(PointerEventData eventData){

		pausa = true;
		canvas.enabled = pausa;
		Time.timeScale = (pausa) ? 0 : 1f;

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space)) {
			pausa = !pausa;
			canvas.enabled = pausa;
			Time.timeScale = (pausa) ? 0 : 1f;
		}
			
	
	}
}
