using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10;
	void Start(){
	}

	void Update()
	{
		//位置の移動//
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		transform.Translate (x * speed, 0, z * speed);
	}
}
