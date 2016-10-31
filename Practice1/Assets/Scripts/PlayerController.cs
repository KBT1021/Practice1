using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10;
	public GameObject Bullet;
	void Start(){
	}

	void Update()
	{
		//位置の移動//
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		transform.Translate (x * speed, 0, z * speed);
		//弾の発射//
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject Bullets = Instantiate (Bullet)as GameObject;
			Bullets.transform.position = transform.position;
			Vector3 force;
			force = this.gameObject.transform.forward * speed;
			Bullets.GetComponent<Rigidbody> ().AddForce (force);
		}
	}
}
