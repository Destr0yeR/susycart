using UnityEngine;
using System.Collections;

public class FaceButtons : MonoBehaviour {

	public GameObject btn_triangle;
	public GameObject btn_circle;
	public GameObject btn_cross;
	public GameObject btn_square;

	private GameObject boton_activo;
	private Vector3 escala;
	private bool puede_palpitar = true; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(boton_activo != null)
		{
			if(puede_palpitar == true)
			{
				StartCoroutine("empezar_palpitar");
			}
		}
	}

	IEnumerator empezar_palpitar()
	{
		puede_palpitar = false;
		yield return new WaitForSeconds(0.1f);
		if(boton_activo.transform.localScale.x <= 1f)
		{
			boton_activo.transform.localScale = new Vector3(1.2f, 1.2f, 1);
		}
		else if(boton_activo.transform.localScale.x > 1f)
		{
			boton_activo.transform.localScale = new Vector3(0.9f, 0.9f, 1);
		}
		puede_palpitar = true;
	}

	public void asignar_boton(int boton)
	{
		switch(boton)
		{
			case 0: boton_activo = btn_triangle; break;
			case 1: boton_activo = btn_circle; break;
			case 2: boton_activo = btn_cross; break;
			case 3: boton_activo = btn_square; break;
		}
		escala = boton_activo.transform.localScale;
	}

	public void desactivar()
	{

	}

	public void resetear_escalas()
	{
		for(int i=0; i<transform.childCount; i++)
		{
			transform.GetChild(i).transform.localScale = new Vector3(1,1,1);
		}
	}
}
