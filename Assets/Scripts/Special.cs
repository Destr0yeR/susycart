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
	public int barrasTotal()
	{
		return barras + cargas * maxBarras;
	}
}
