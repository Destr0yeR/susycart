using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

	public GUIText texto_susy;
	public GUIText texto_mudo;
	public GUIText texto_bigote;
	public GUIText texto_loco;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		texto_susy.text = GameController.Instancia.getCarreraSusy().puesto + "/4";
		texto_mudo.text = GameController.Instancia.getCarreraMudo().puesto + "/4";
		texto_bigote.text = GameController.Instancia.getCarreraBigote().puesto + "/4";
		texto_loco.text = GameController.Instancia.getCarreraLoco().puesto + "/4";
	}

	void OnGUI()
	{

	}
}
