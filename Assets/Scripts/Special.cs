using UnityEngine;
using System.Collections;

public class Special : MonoBehaviour {

	// Use this for initialization

	private int cargas;
	private int barras;
	public int maxBarras;

	void Start () 
	{
		cargas = 0;
		barras = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		CheckBarras();
		if (cargas > 10) 
		{
			Debug.Log("bla bla cargas");
		}
	}

	void CheckBarras()
	{
		if(barras >= maxBarras)
		{
			cargas += barras/maxBarras;
			barras  = barras%maxBarras;
		}
	}

	public void AgregarCarga()
	{
		cargas += 1;
	}
}
