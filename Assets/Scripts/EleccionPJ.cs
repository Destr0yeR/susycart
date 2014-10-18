using UnityEngine;
using System.Collections;

public class EleccionPJ : MonoBehaviour {

	private bool ready_1 = false;
	private bool ready_2 = false;
	private bool ready_3 = false;
	private bool ready_4 = false;

	public SpriteRenderer fondo1;
	public SpriteRenderer fondo2;
	public SpriteRenderer fondo3;
	public SpriteRenderer fondo4;

	private int listos = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Joystick1Button9) && ready_1 == false)
		{
			ready_1 = true;
			fondo1.enabled = true;
			listos++;
		}

		if(Input.GetKeyDown(KeyCode.Joystick2Button9) && ready_2 == false)
		{
			ready_2 = true;
			fondo2.enabled = true;
			listos++;
		}

		if(Input.GetKeyDown(KeyCode.Joystick3Button9) && ready_3 == false)
		{
			ready_3 = true;
			fondo3.enabled = true;
			listos++;
		}

		if(Input.GetKeyDown(KeyCode.Joystick4Button9) && ready_4 == false)
		{
			ready_4 = true;
			fondo4.enabled = true;
			listos++;
		}

		if(listos == 4)
		{
			Application.LoadLevel("main");
		}
	}
}
