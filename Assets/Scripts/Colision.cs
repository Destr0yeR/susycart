using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

	Carrera carrera;
	Special special;
	public GameObject Player;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Obstaculo") 
		{
			if(gameObject.tag == "Player")
			{
				carrera = gameObject.GetComponent<Carrera>();
				carrera.StartCoroutine("reduceVelocity");
				special = gameObject.GetComponent<Special>();
				special.ResetearBarra();
			}
			if(gameObject.tag == "Barrera")
			{
				special = Player.gameObject.GetComponent<Special>();
				special.AgregarBarra();
			}
			Destroy(other.gameObject);
		} 
	}
}
