using UnityEngine;
using System.Collections;

public class SpecialBar : MonoBehaviour {

	// Use this for initialization
	public GameObject Player;
	private Special special;
	public Sprite[] barras;
	private int total;

	void Start () {
		special = Player.gameObject.GetComponent<Special>();
	}
	
	// Update is called once per frame
	void Update () {
		total = special.barrasTotal ();
		gameObject.GetComponent<SpriteRenderer>().sprite = barras[total];
		Debug.Log(total);
	}
}
