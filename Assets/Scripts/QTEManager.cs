using UnityEngine;
using System.Collections;

public class QTEManager : MonoBehaviour {

	private float tiempo_qte;

	private const int _TIA = 0;
	private const int _MUDO = 1;
	private const int _BIGOTE = 2;
	private const int _LOCO = 3;

	private int jugador_actual;
	private int jugadores_activos;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void iniciar_ronda()
	{
		jugador_actual = _TIA;
		jugadores_activos = 4;
		asignar_QTE(_TIA);
	}

	void asignar_QTE(int index)
	{

	}
}
