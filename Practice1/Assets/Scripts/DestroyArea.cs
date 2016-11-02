using UnityEngine;
using System.Collections;

public class DestroyArea : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	void Start () {
		transform.position = Player.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Player.transform.position;
	}
	void OnTriggerExit(Collider other){
		Destroy (other.gameObject);
	}
}
