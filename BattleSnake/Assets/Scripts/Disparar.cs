using UnityEngine;
using System.Collections;

public class Disparar : MonoBehaviour {


	public LayerMask what_hit;
	public Rigidbody2D disparo;
	public GameObject cab;
	public float velocidad_disparo = 10f;
	public static int nivel = 1;

	void Start () {


		disparo = GetComponent<Rigidbody2D>();
		cab = GameObject.Find("Personaje");
		disparo.transform.rotation = cab.transform.rotation;
	
	}
	

	void Update () {
		
		disparo.transform.Translate (0,-velocidad_disparo*Time.deltaTime,0);
	

	}
		
	void OnBecameInvisible(){
		Destroy (gameObject);
		Mover.wait = false;
	}


}

