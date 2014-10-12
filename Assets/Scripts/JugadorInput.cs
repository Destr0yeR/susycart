using UnityEngine;
using System.Collections;

public class JugadorInput : MonoBehaviour {

	public int num_jugador;

	private KeyCode _TRIANGLE;
	private KeyCode _SQUARE;
	private KeyCode _CIRCLE;
	private KeyCode _CROSS;

	private KeyCode _L1;
	private KeyCode _R1;

	private string axis;

	// Use this for initialization
	void Start () 
	{
		set_keys_jugador();

	}
	
	// Update is called once per frame
	void Update () 
	{
		verificar_input();
	}

	void set_keys_jugador ()
	{
		switch(num_jugador)
		{
			case 1: _TRIANGLE = KeyCode.Joystick1Button0;
					_SQUARE = KeyCode.Joystick1Button3;
					_CIRCLE = KeyCode.Joystick1Button1;
					_CROSS = KeyCode.Joystick1Button2;
					_L1 = KeyCode.Joystick1Button6;
					_R1 = KeyCode.Joystick1Button7;
					break;
			case 2: _TRIANGLE = KeyCode.Joystick2Button0;
					_SQUARE = KeyCode.Joystick2Button3;
					_CIRCLE = KeyCode.Joystick2Button1;
					_CROSS = KeyCode.Joystick2Button2;
					_L1 = KeyCode.Joystick2Button6;
					_R1 = KeyCode.Joystick2Button7;
					break;
			case 3: _TRIANGLE = KeyCode.Joystick3Button0;
					_SQUARE = KeyCode.Joystick3Button3;
					_CIRCLE = KeyCode.Joystick3Button1;
					_CROSS = KeyCode.Joystick3Button2;
					_L1 = KeyCode.Joystick3Button6;
					_R1 = KeyCode.Joystick3Button7;
					break;
			case 4: _TRIANGLE = KeyCode.Joystick4Button0;
					_SQUARE = KeyCode.Joystick4Button3;
					_CIRCLE = KeyCode.Joystick4Button1;
					_CROSS = KeyCode.Joystick4Button2;
					_L1 = KeyCode.Joystick4Button6;
					_R1 = KeyCode.Joystick4Button7;
					break;
		}
		axis = "Mando-" + num_jugador;
	}

	void verificar_input ()
	{
		if(Input.GetKeyDown(_R1))
		{
			GameController.Instancia.getJugadorIndex(num_jugador-1).SendMessage("mover_derecha");
		}
		else if(Input.GetKeyDown(_L1))
		{
			GameController.Instancia.getJugadorIndex(num_jugador-1).SendMessage("mover_izquierda");
		}

		if(Input.GetKeyDown(_SQUARE))
		{
			GameController.Instancia.getJugadorIndex(num_jugador-1).SendMessage("presionar_cuadrado");
		}

		if(Input.GetKeyDown(_CROSS))
		{
			GameController.Instancia.getJugadorIndex(num_jugador-1).SendMessage("presionar_equis");
		}

		if(Input.GetKeyDown(_CIRCLE))
		{
			GameController.Instancia.getJugadorIndex(num_jugador-1).SendMessage("presionar_circulo");
		}

		if(Input.GetKeyDown(_TRIANGLE))
		{
			GameController.Instancia.getJugadorIndex(num_jugador-1).SendMessage("presionar_triangulo");
		}
	}
}
