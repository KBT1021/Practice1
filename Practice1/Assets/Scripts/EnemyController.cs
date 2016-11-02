using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	//dz=dxの2次式の形で表す.このScriptにrotを組みこめば2次式の範囲でいろんな方向に動かせる//
	public float x3co =0;
	public float x2co = 10;
	public float x1co = 0;
	//Playerからの位置（スクロール対策）//
	public float initialx = 10;
	public float initialz = 10;
	public float speed = 1;
	public float speedx=1;
	public float vanishtime=10.0f;
	public GameObject Player;


	// Use this for initialization
	void Start () {
		transform.position=Player.transform.position;
		transform.Translate (initialx, 0, initialz);
	}
		
	// Update is called once per frame
	void Update () {
		float delta = 0.1f;
		float dx = delta * speed;
	//放物線上を動くようにしてみるz=x2co*dx^2+x1co*dx//
		transform.Translate (dx*speedx,0,x3co*dx*dx*dx+x2co*dx*dx+x1co*dx);
		Destroy (gameObject,vanishtime);
	}
}
