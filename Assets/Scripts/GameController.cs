using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private static GameController instancia;
	public GameObject[] jugadores = new GameObject[4];
	public GameObject[] pistas = new GameObject[4];

	private Carrera[] carreras = new Carrera[4];
	
	private const int _TIA = 0;
	private const int _MUDO = 1;
	private const int _BIGOTE = 2;
	private const int _LOCO = 3;

	private bool hayGanador;
	private bool puede_verificar_puesto;

	public float distancia;

	void Awake()
	{
		instancia = this;
	}

	void Start () 
	{
		hayGanador = false;
		puede_verificar_puesto = true;
		inicializar_carreras();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("space"))
		{
			gameObject.GetComponent<QTEManager>().iniciar_ronda();
		}

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
				Debug.Log("TIA GANA");
			}
			else if (carreras[_MUDO].getRecorrido() > distancia)
			{
				hayGanador = true;
				Debug.Log("MUDO GANA");
			}
			else if (carreras[_BIGOTE].getRecorrido() > distancia)
			{
				hayGanador = true;
				Debug.Log("BIGOTE GANA");
			}
			else if (carreras[_LOCO].getRecorrido() > distancia)
			{
				hayGanador = true;
				Debug.Log("LOCO GANA");
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

	public Carrera getCarreraIndex(int index)
	{
		switch(index)
		{
			case _TIA: return carreras[_TIA]; break;
			case _MUDO: return carreras[_MUDO]; break;
			case _BIGOTE: return carreras[_BIGOTE]; break;
			case _LOCO: return carreras[_LOCO]; break;
		}

		return null;
	}

	public Carrera getCarreraTia()
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

	public GameObject getTia()
	{
		return jugadores[_TIA];
	}

	public GameObject getMudo()
	{
		return jugadores[_MUDO];
	}

	public GameObject getBigote()
	{
		return jugadores[_BIGOTE];
	}

	public GameObject getLoco()
	{
		return jugadores[_LOCO];
	}

	public GameObject getJugadorIndex(int index)
	{
		switch(index)
		{
			case _TIA: return jugadores[_TIA]; break;
			case _MUDO: return jugadores[_MUDO]; break;
			case _BIGOTE: return jugadores[_BIGOTE]; break;
			case _LOCO: return jugadores[_LOCO]; break;
		}
		
		return null;
	}

	public GameObject getPistaIndex(int index)
	{
		switch(index)
		{
			case _TIA: return pistas[_TIA]; break;
			case _MUDO: return pistas[_MUDO]; break;
			case _BIGOTE: return pistas[_BIGOTE]; break;
			case _LOCO: return pistas[_LOCO]; break;
		}
		
		return null;
	}

	public static GameController Instancia {
		get {
			return instancia;
		}
	}
}
