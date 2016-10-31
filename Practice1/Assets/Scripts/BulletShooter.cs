using UnityEngine;
using System.Collections;

public class BulletShooter : MonoBehaviour {
	public GameObject BulletPrefab;
	public GameObject Machine;

	public float speed = 100;
	public float vanishtime=10;

	void Start () {
	}

	void FixedUpdate () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Shoot ();
		}
	}
	//弾を発射-消去する//
	void Shoot(){
		//弾のコピーをプレハブから作る//
		GameObject Bullet = Instantiate (BulletPrefab)as GameObject;
		//Enemyにも転用可能//
		Bullet.transform.position = Machine.transform.position;
		Rigidbody BulletRigid = Bullet.GetComponent<Rigidbody> ();
		BulletRigid.AddForce (transform.forward * speed,ForceMode.Impulse);
		Destroy (Bullet, vanishtime);
	}
}
