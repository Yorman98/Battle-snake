using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed = 1f;
	private Rigidbody2D rb2d; 
	private float angle = 2.5f;
	public GameObject disparo;
	private Vector3 pos_ini;
	public Control izquierda;
	public Control derecha;
	public Shoot dis;
	public static bool wait=false;


 	void Start () {
	
		rb2d = GetComponent<Rigidbody2D>();
		pos_ini = transform.position;
	}

	
	void FixedUpdate(){
		
		//Mueve a la cabeza de la serpiente en el eje y
		rb2d.transform.Translate( 0 , -speed*Time.deltaTime ,0);

		if (izquierda.touch) {
			transform.Rotate (0, 0, angle);
		}
		if (derecha.touch) {
			transform.Rotate (0, 0, -angle);
		}

		if (dis.shoot && wait == false){
			wait = true;
			dis.shoot = false;
			Vector3 pos = this.transform.position;
			disparo.transform.Rotate (0,0,this.transform.rotation.z);
			Instantiate (disparo, pos , Quaternion.identity);
			
		}

	}//FiXED UPDATE
		
	void fire(){

		Vector3 pos = this.transform.position;
		disparo.transform.Rotate (0,0,this.transform.rotation.z);
			
		Instantiate (disparo, pos , Quaternion.identity);

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Borde") {
			this.transform.position = pos_ini;
			BarraVida.Health = BarraVida.Health - 5;
		}
			

	}

}
