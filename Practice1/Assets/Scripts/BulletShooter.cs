using UnityEngine;
using System.Collections;

public class BulletShooter : MonoBehaviour {
	public GameObject BulletPrefab;

	public Transform Muzzle;

	public float speed = 100;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Shoot ();
		}
	}
	void Shoot(){
		GameObject Bullets = Instantiate (BulletPrefab)as GameObject;
		transform.position = Muzzle.position;
		Vector3 force;
		force = this.gameObject.transform.forward * speed;
		Bullets.GetComponent<Rigidbody> ().AddForce (force);
	}
}
