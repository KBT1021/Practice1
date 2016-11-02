using UnityEngine;
using System.Collections;

public class EnemyBulletShooter : MonoBehaviour {
	public float speed=5;
	public float vanishtime=2;
	public float number=10;
	public float span=0.5f;
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
			if (this.delta > this.span) {
			if (count < number) {
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
		//弾の発射//
		Rigidbody BulletRigid = Bullet.GetComponent<Rigidbody>();
		BulletRigid.AddForce (transform.forward * speed, ForceMode.Impulse);
		//弾の消失//
		Destroy (Bullet, vanishtime);
	}
		
}
