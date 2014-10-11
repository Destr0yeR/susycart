using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization

	public GameObject[] jugadores = new GameObject[4];
	private Carrera[] carreras = new Carrera[4];

	private const int _TIA = 0;
	private const int _MUDO = 1;
	private const int _BIGOTE = 2;
	private const int _LOCO = 3;

	private bool hayGanador;
	private bool puede_verificar_puesto;

	public float distancia;

	void Start () 
	{
		hayGanador = false;
		puede_verificar_puesto = true;
		inicializar_carreras();
	}
	
	// Update is called once per frame
	void Update () 
	{
		verificar_ganador();
		if(puede_verificar_puesto == true)
		{
			StartCoroutine("verificar_puesto");
		}
	}

	void verificar_ganador ()
	{
		if(hayGanador == false)
		{
			if (carreras[_TIA].getRecorrido() > distancia)
			{
				hayGanador = true;
			}
			else if (carreras[_MUDO].getRecorrido() > distancia)
			{
				hayGanador = true;
			}
			else if (carreras[_BIGOTE].getRecorrido() > distancia)
			{
				hayGanador = true;
			}
			else if (carreras[_LOCO].getRecorrido() > distancia)
			{
				hayGanador = true;
			}
		}
	}

	IEnumerator verificar_puesto()
	{
		int puesto_temp;
		puede_verificar_puesto = false;

		for(int i=0; i<4; i++)
		{
			for(int j=0; j<4; j++)
			{
				if(i != j && carreras[i].recorrido > carreras[j].recorrido && carreras[i].puesto > carreras[j].puesto)
				{
					puesto_temp = carreras[i].puesto;
					carreras[i].puesto = carreras[j].puesto;
					carreras[j].puesto = puesto_temp;
				}
			}
		}

		yield return new WaitForSeconds(1f);
		puede_verificar_puesto = true;
	}

	void inicializar_carreras ()
	{
		carreras[_TIA] = jugadores[_TIA].GetComponent<Carrera>();
		carreras[_MUDO] = jugadores[_MUDO].GetComponent<Carrera>();
		carreras[_BIGOTE] = jugadores[_BIGOTE].GetComponent<Carrera>();
		carreras[_LOCO] = jugadores[_LOCO].GetComponent<Carrera>();
	}

	public Carrera getCarreraSusy()
	{
		return carreras[_TIA];
	}

	public Carrera getCarreraMudo()
	{
		return carreras[_MUDO];
	}

	public Carrera getCarreraBigote()
	{
		return carreras[_BIGOTE];
	}

	public Carrera getCarreraLoco()
	{
		return carreras[_LOCO];
	}
}
