using UnityEngine;
using System.Collections;

public class ValidadorQTE : MonoBehaviour {
	
	private bool activo;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(activo == true)
		{
			verificar_activacion_qte();
		}
	}

	void verificar_activacion_qte()
	{

	}

	void activar()
	{
		activo = true;
	}

	void desactivar()
	{
		activo = false;
	}
}
