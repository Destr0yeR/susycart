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
		Carrera susanaDistancia = susana.GetComponent<Carrera>();
		Carrera locoDistancia = loco.GetComponent<Carrera>();
		Carrera cornejoDistancia = cornejo.GetComponent<Carrera>();
		Carrera castañedaDistancia = castañeda.GetComponent<Carrera>();

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
