using UnityEngine;
using System.Collections;

public class ValidadorQTE : MonoBehaviour {
	
	private bool activo;
	private bool haPerdido;
	public bool leToca;
	private int boton_asignado;
	private int num_jugador;

	// Use this for initialization
	void Start () 
	{
		num_jugador = gameObject.GetComponent<JugadorInput>().num_jugador;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void activar()
	{
		activo = true;
		haPerdido = false;
	}

	public void asignar(int boton)
	{
		boton_asignado = boton;
		leToca = true;
		StartCoroutine("empezar_timer");
	}

	void desactivar()
	{
		activo = false;
	}
	
	void completar ()
	{
		StopCoroutine("empezar_timer");
		leToca = false;
		QTEManager.Instancia.declarar_acierto(num_jugador);
	}
	
	void fallar ()
	{
		activo = false;
		haPerdido = true;
		leToca = false;
		QTEManager.Instancia.declarar_error(num_jugador);
	}

	IEnumerator empezar_timer()
	{
		yield return new WaitForSeconds(0.8f);
		fallar ();
	}

	void presionar_cuadrado()
	{
		if(leToca == true)
		{
			if(boton_asignado == 3)
			{
				completar();
			}
			else
			{
				fallar();
			}
		}
	}

	void presionar_equis()
	{
		if(leToca == true)
		{
			if(boton_asignado == 2)
			{
				completar();
			}
			else
			{
				fallar();
			}
		}
	}

	void presionar_circulo()
	{
		if(leToca == true)
		{
			if(boton_asignado == 1)
			{
				completar();
			}
			else
			{
				fallar();
			}
		}
	}

	void presionar_triangulo()
	{
		if(leToca == true)
		{
			if(boton_asignado == 0)
			{
				completar();
			}
			else
			{
				fallar();
			}
		}
	}
	public int Boton_asignado {
		get {
			return boton_asignado;
		}
		set {
			boton_asignado = value;
		}
	}

	public bool Activo {
		get {
			return activo;
		}
		set {
			activo = value;
		}
	}

	public bool HaPerdido {
		get {
			return haPerdido;
		}
		set {
			haPerdido = value;
		}
	}

	public bool LeToca {
		get {
			return leToca;
		}
		set {
			leToca = value;
		}
	}
}
