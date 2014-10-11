using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization

	public GameObject susana;
	public GameObject loco;
	public GameObject cornejo;
	public GameObject castañeda;

	private bool hayGanador;

	public float distancia;

	void Start () 
	{
		hayGanador = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Distancia susanaDistancia 		= susana.GetComponent<Distancia>();
		Distancia locoDistancia 		= loco.GetComponent<Distancia>();
		Distancia cornejoDistancia 		= cornejo.GetComponent<Distancia>();
		Distancia castañedaDistancia 	= castañeda.GetComponent<Distancia>();

		Debug.Log(susanaDistancia.getRecorrido());
		if(!hayGanador)
		{
			if (susanaDistancia.getRecorrido() > distancia)
			{
				Debug.Log("Susy gana");
				hayGanador = true;
			}
			else if (locoDistancia.getRecorrido() > distancia)
			{
				Debug.Log("Loco gana");
				hayGanador = true;
			}
			else if (cornejoDistancia.getRecorrido() > distancia)
			{
				Debug.Log("Cornejo gana");
				hayGanador = true;
			}
			else if (castañedaDistancia.getRecorrido() > distancia)
			{
				Debug.Log("Castañeda gana");
				hayGanador = true;
			}
		}
	}

}
