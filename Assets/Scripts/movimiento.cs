using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

	// Use this for initialization
	public Transform CarrilL;
	public Transform CarrilC;
	public Transform CarrilR;

	private bool isLeft;
	private bool isCenter;
	private bool isRight;

	void Start () {
		isLeft = false;
		isCenter = true;
		isRight = false;
	}
	
	// Update is called once per frame
	void Update () {
		revisarInput();
	}

	void revisarInput()
	{
		if(Input.GetKeyUp("a") && !isLeft)
		{
			if(isCenter)
			{
				isLeft = true;
				isCenter = false;
			}
			if(isRight)
			{
				isRight = false;
				isCenter = true;
			}
			transform.position = new Vector3(CarrilL.position.x,transform.position.y,transform.position.z);
		}
		if(Input.GetKeyUp("d") && !isRight)
		{
			if(isCenter)
			{
				isRight = true;
				isCenter = false;
			}
			if(isLeft)
			{
				isLeft = false;
				isCenter = true;
			}
			transform.position = new Vector3(CarrilR.position.x,transform.position.y,transform.position.z);
		}
	}

}
