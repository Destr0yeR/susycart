using UnityEngine;
using System.Collections;

public class Special : MonoBehaviour {

	// Use this for initialization

	private int cargas;
	private int barras;
	public int maxBarras;
	public int maxCargas;

	void Start () 
	{
		cargas = 0;
		barras = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		CheckBarras();
		if (cargas > 0 || barras > 0) 
		{
			Debug.Log (cargas);
			Debug.Log (barras);
		}
		if (cargas == 3) 
		{
			Debug.Log("puto");
		}

	}

	void CheckBarras()
	{
		if(barras >= maxBarras)
		{
			cargas += barras/maxBarras;
			barras  = barras%maxBarras;
		}
		if (cargas == maxCargas) 
		{
			barras = 0;
		}
	}

	public void AgregarBarra()
	{
		if (cargas < maxCargas) 
		{
			barras += 1;
		}
	}
	public void ResetearBarra()
	{
		barras = 0;
	}
}
