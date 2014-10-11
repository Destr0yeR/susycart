using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

	Carrera carrera;

	void onCollisionEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			GameObject Player = other.gameObject;
			carrera = Player.GetComponent<Carrera>();
			carrera.StartCoroutine("reduceVelocity");
			Destroy(gameObject);
		} 
	}
}
