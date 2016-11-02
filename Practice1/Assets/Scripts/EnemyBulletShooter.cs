using UnityEngine;
using System.Collections;

public class EnemyBulletShooter : MonoBehaviour {
	public float Speed=5;
	public float BulletNumber=10;
	public float ShootSpan=0.5f;
	//砲台の角度の設定可能//
	public float AngularY=0;
	float delta=0;
	int count=0;
	public GameObject BulletPrefab;
	public GameObject Machine;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.delta += Time.deltaTime;
			if (this.delta > this.ShootSpan) {
			if (count < BulletNumber) {
				this.delta = 0;
				Shoot ();
			}
			count++;
			}
		}
	void Shoot(){
		//弾の生成//
		GameObject Bullet = Instantiate (BulletPrefab)as GameObject;
		Bullet.transform.position = Machine.transform.position;
		transform.rotation = Quaternion.Euler (0,AngularY,0);
		//弾の発射//
		Rigidbody BulletRigid = Bullet.GetComponent<Rigidbody>();
		BulletRigid.AddForce (transform.forward * Speed, ForceMode.Impulse);
		//弾の消失:DestroyAreaで管理//
	}
		
}
