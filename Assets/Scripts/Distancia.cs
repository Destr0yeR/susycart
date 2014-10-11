using UnityEngine;
using System.Collections;

public class Distancia : MonoBehaviour {

	// Use this for initialization

	private float recorrido;
	public float velocity;

	void Start () 
	{
		recorrido = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		recorrido += velocity*Time.deltaTime;
	}
	public float getRecorrido()
	{
		return recorrido;
	}
}
