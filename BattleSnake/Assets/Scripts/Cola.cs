using UnityEngine;
using System.Collections;

public class Cola : MonoBehaviour {

	public GameObject Cab;
//	private Rigidbody2D cola;
	float speed = 0.009f;
	private Vector3 pos_ini;


	void Start () {
		Cab = GameObject.FindGameObjectWithTag ("Cabeza");
		//cola = GetComponent<Rigidbody2D> ();
		pos_ini = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 target = Cab.transform.position;

		this.transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime); 
	}

	void OnTriggerEnter2D(Collider2D col){


		if (col.gameObject.tag == "Borde") {
			this.transform.position = pos_ini;
		}
	}
}
