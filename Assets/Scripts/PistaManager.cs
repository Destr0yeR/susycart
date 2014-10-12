using UnityEngine;
using System.Collections;

public class PistaManager : MonoBehaviour {

	// Use this for initialization
	public GameObject pista;
	private GameObject player;

	void Start () {
		player = gameObject.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Choque()
	{
		pista.GetComponent<Pista>().StartCoroutine("reduceVelocity");
	}

}
