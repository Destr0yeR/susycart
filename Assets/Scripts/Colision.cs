using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

	Carrera carrera;
	public GameObject Player;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Obstaculo") 
		{
			if(gameObject.tag == "Player")
			{
				carrera = gameObject.GetComponent<Carrera>();
				carrera.StartCoroutine("reduceVelocity");
			}
			if(gameObject.tag == "Barrera")
			{
				Special special = Player.gameObject.GetComponent<Special>();
				special.AgregarCarga();
			}
			Destroy(other.gameObject);
		} 
	}
}
