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
}
