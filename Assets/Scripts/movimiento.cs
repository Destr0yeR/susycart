using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	// Use this for initialization
	public Transform CarrilL;
	public Transform CarrilC;
	public Transform CarrilR;

	private bool isLeft;
	private bool isCenter;
	private bool isRight;

	void Start () 
	{
		isLeft = false;
		isCenter = true;
		isRight = false;
	}

	void mover_derecha()
	{
		Debug.Log("derecheando");
		if(isRight == false)
		{
			if(isCenter == true)
			{
				isRight = true;
				isCenter = false;
			}
			if(isLeft == true)
			{
				isLeft = false;
				isCenter = true;
			}
			transform.position = new Vector3(CarrilR.position.x,transform.position.y,transform.position.z);
		}
	}

	void mover_izquierda()
	{
		Debug.Log("izquierdando");
		if(isLeft == false)
		{
			if(isCenter == true)
			{
				isLeft = true;
				isCenter = false;
			}
			if(isRight == true)
			{
				isRight = false;
				isCenter = true;
			}
			transform.position = new Vector3(CarrilL.position.x,transform.position.y,transform.position.z);
		}
	}
}
