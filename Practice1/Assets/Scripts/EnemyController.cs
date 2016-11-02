using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	//dz=dxの2次式の形で表す.このScriptにrotを組みこめば3次式の範囲でいろんな方向に動かせる//
	public float x3Coefficient = 0;
	public float x2Coefficient = 0;
	public float x1Coefficient = 10;
	//Playerからの位置（スクロール対策）//
	public float InitialX = 10;
	public float InitialZ = 10;
	public float MachineSpeed = 1;
	public float SpeedOfX = 1;
	public float VanishTime = 10.0f;
	public GameObject Player;


	// Use this for initialization
	void Start () {
		transform.position=Player.transform.position;
		transform.Translate (InitialX, 0, InitialZ);
	}
	
	// Update is called once per frame
	void Update () {
		float delta = 0.01f;
		float dx = delta * MachineSpeed;
		float speedx = SpeedOfX;
		float x2co = x2Coefficient;
		float x1co = x1Coefficient;
		float x3co = x3Coefficient;
	//放物線上を動くようにしてみるz=x2co*x^2+x1co*x+x0co//
		transform.Translate(dx*speedx,0,x3co*dx*dx*dx+x2co*dx*dx+x1co*dx);
		Destroy (gameObject,VanishTime);
	}
	void OnTriggerEnter(Collider other){
		Destroy (gameObject);
		Destroy (other.gameObject);
	}
}
