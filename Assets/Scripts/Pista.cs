using UnityEngine;
using System.Collections;

public class Pista : MonoBehaviour {
	
	public int num_pista;
	
	// Use this for initialization
	void Start () 
	{
		gameObject.GetComponent<Animator>().SetInteger("Pista", num_pista);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator reduceVelocity()
	{
		gameObject.GetComponent<Animator> ().speed = 0.4f;
		yield return new WaitForSeconds(1.0f);
		StartCoroutine("increaseVelocity");
		StopCoroutine("reduceVelocity");
	}
	IEnumerator increaseVelocity()
	{
		gameObject.GetComponent<Animator> ().speed = 1.0f;
		yield return new WaitForSeconds(1.0f);
		StopCoroutine("increaseVelocity");
	}
}
