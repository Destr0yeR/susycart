using UnityEngine;
using System.Collections;

public class Carrera : MonoBehaviour {

	// Use this for initialization

	private float recorrido;
	public float velocity;

	public float Velocity {
		get {
			return velocity;
		}
		set {
			velocity = value;
		}
	}

	void Start () 
	{
		recorrido = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		recorrido += velocity*Time.deltaTime;
	}
	public float getRecorrido()
	{
		return recorrido;
	}
	public void setVelocity(float v)
	{
		velocity = v;
	}
	IEnumerator reduceVelocity()
	{
		while(velocity>0)
		{
			velocity -= 0.1f;
			yield return new WaitForSeconds(0.2f);
		}
		StopCoroutine("reduceVelocity");
	}
}
