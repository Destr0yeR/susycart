using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

	Carrera carrera;
	Special special;
	PistaManager pista;
	public GameObject Player;

	private int obstaculos;
	private int choquesBarrera;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Obstaculo") 
		{
			if(gameObject.tag == "Player")
			{
				carrera = gameObject.GetComponent<Carrera>();
				pista = gameObject.GetComponent<PistaManager>();
				pista.Choque();
				carrera.StartCoroutine("reduceVelocity");
				special = gameObject.GetComponent<Special>();
				special.ResetearBarra();
			}
			if(gameObject.tag == "Barrera")
			{
				/*special = Player.gameObject.GetComponent<Special>();
				special.AgregarBarra();*/
				choquesBarrera += 1;
				if(obstaculos == choquesBarrera)
				{
					//Debug.Log("pasa");
					special = Player.gameObject.GetComponent<Special>();
					special.AgregarBarra();
				}
			}
			Destroy(other.gameObject);
		}
	}

	public void setObstaculos(int obs)
	{
		obstaculos = obs;
	}
	public void resetChoques()
	{
		choquesBarrera = 0;
	}


}
