using UnityEngine;
using System.Collections;

public class PlayerBulletShooter : MonoBehaviour {
	public GameObject BulletPrefab;
	public GameObject Machine;

	public float speed = 100;
	public float vanishtime = 2;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Shoot ();
		}
	}
	void Shoot(){
		//弾の生成//
		GameObject Bullet = Instantiate (BulletPrefab)as GameObject;
		Bullet.transform.position = Machine.transform.position;
		//弾の発射//
		Rigidbody BulletRigid = Bullet.GetComponent<Rigidbody>();
		BulletRigid.AddForce (transform.forward * speed, ForceMode.Impulse);
		//弾の消失//
		Destroy (Bullet, vanishtime);
	}
}
