using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

	public GameObject Cab;
//	private Rigidbody2D rb2d; 
	public float speed,speed_ini;
	private float radio = 2.5f;


	void Start () {
	//	rb2d = GetComponent<Rigidbody2D>();

		Cab = GameObject.FindGameObjectWithTag("Cabeza");
		speed_ini = speed;
	}
	

	void  Update() {

		Cab = GameObject.FindGameObjectWithTag("Cabeza");

		Vector3 target = Cab.transform.position;

		float dist = Vector3.Distance (Cab.transform.position, transform.position);

		if (dist < radio) {

			if (speed > 0.5) speed =speed - 0.01f;
		}else
			speed = speed_ini;
		
		this.transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

	}

	void OnDrawGizmos(){

		Gizmos.color = Color.black;
		Gizmos.DrawWireSphere (transform.position,radio);

	}
	void OnTriggerEnter2D(Collider2D col){

		if (col.gameObject.tag == "Disparo") {
			
			Destroy (gameObject);
		}
	}


}
