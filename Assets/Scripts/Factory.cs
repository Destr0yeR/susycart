using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {
	
	// Use this for initialization
	
	public float tiempo;
	private float tiempoIteracion;
	
	public GameObject prefab_roca;
	public GameObject barrera;
	
	private GameObject[] obstaculos = new GameObject[2];
	
	private int numero;
	public bool activado;
	
	private bool ocupadoCarril1;
	private bool ocupadoCarril2;
	private bool ocupadoCarril3;
	
	public Transform CarrilL;
	public Transform CarrilC;
	public Transform CarrilR;
	
	private 
		
	void Start () {
		activado = true;
		ocupadoCarril1 = false;
		ocupadoCarril2 = false;
		ocupadoCarril3 = false;
		tiempoIteracion = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (activado) 
		{
			if(tiempoIteracion > tiempo )
			{
				float random = 2.0f * Random.value;
				
				Colision colision = barrera.GetComponent<Colision> ();
				colision.resetChoques();
				
				obstaculos[0] = Instantiate(prefab_roca) as GameObject;
				setAtributos(obstaculos[0]);
				int obs = 1;
				if(random >= 1.0f )
				{
					obstaculos[1] = Instantiate(prefab_roca) as GameObject;
					setAtributos(obstaculos[1]);
					obs = 2;
				}
				
				colision.setObstaculos(obs);
				
				tiempoIteracion = 0.0f;
				
				ocupadoCarril1 = false;
				ocupadoCarril2 = false;
				ocupadoCarril3 = false;
			}
			tiempoIteracion += Time.deltaTime;  
		}
	}
	
	void setAtributos(GameObject Instancia)
	{
		Vector2 velocity = new Vector2(0,0);
		Transform position = CarrilC;
		bool hecho = false;
		
		Obstaculo obstaculo = Instancia.GetComponent<Obstaculo> ();
		
		do
		{
			float random = 3.0f * Random.value;
			if(random < 1.0f)
			{
				if(!ocupadoCarril1)
				{
					position = CarrilL;
					velocity = new Vector2(-2.2f,-3.0f);
					ocupadoCarril1 = true;
					hecho = true;
				}
			}
			else if(random < 2.0f)
			{
				if(!ocupadoCarril2)
				{
					position = CarrilC;
					velocity = new Vector2(0.0f,-3.0f);
					ocupadoCarril2 = true;
					hecho = true;
				}
			}
			else
			{
				if(!ocupadoCarril3)
				{
					position = CarrilR;
					velocity = new Vector2(2.2f,-3.0f);
					ocupadoCarril3 = true;
					hecho = true;
				}
			}
		}
		while(!hecho);
		
		obstaculo.setVelocity (velocity);
		obstaculo.setPosition (position);
		
	}
}
