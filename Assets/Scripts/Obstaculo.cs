using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour {

	// Use this for initialization
	private int position;

	private Vector2 velocity;
	private float escala;

	void Start () 
	{
		escala = 0.001f;
	}

	public void setVelocity(Vector2 velocidad)
	{
		rigidbody2D.velocity = new Vector2(velocidad.x,velocidad.y);
	}
	public void setPosition(Transform carril)
	{
		transform.position = new Vector3(carril.position.x,carril.position.y,carril.position.z);
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (rigidbody2D.velocity);
		escala *= 1.15f;
		transform.localScale += new Vector3(escala,escala,1);
	}


}
