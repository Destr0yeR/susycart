using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

	public static HUDController instancia;

	public bool puede_renderizar = true;

	public GUIText texto_susy;
	public GUIText texto_mudo;
	public GUIText texto_bigote;
	public GUIText texto_loco;

	void Awake()
	{
		instancia = this;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(puede_renderizar == true)
		{
			texto_susy.text = GameController.Instancia.getCarreraTia().puesto + "/4";
			texto_mudo.text = GameController.Instancia.getCarreraMudo().puesto + "/4";
			texto_bigote.text = GameController.Instancia.getCarreraBigote().puesto + "/4";
			texto_loco.text = GameController.Instancia.getCarreraLoco().puesto + "/4";
		}
		else
		{
			texto_susy.text = "";
			texto_mudo.text = "";
			texto_bigote.text = "";
			texto_loco.text = "";
		}
	}

	void OnGUI()
	{

	}
}
