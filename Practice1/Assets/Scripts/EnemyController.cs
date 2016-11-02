using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	//dz=dxの2次式の形で表す.このScriptにrotを組みこめば3次式の範囲でいろんな方向に動かせる//
	public float x2co = 0;
	public float x1co = 10;
	public float x0co = 0;
	//Playerからの位置（スクロール対策）//
	public float initialx = 10;
	public float initialz = 10;
	public float machinespeed = 1;
	public float speedx = 1;
	public float vanishtime=10.0f;
	public GameObject Player;


	// Use this for initialization
	void Start () {
		transform.position=Player.transform.position;
		transform.Translate (initialx, 0, initialz);
	}
	
	// Update is called once per frame
	void Update () {
		float delta = 0.01f;
		float dx = delta * machinespeed;
	//放物線上を動くようにしてみるz=x2co*x^2+x1co*x+x0co//
		transform.Translate(dx*speedx,0,x2co*dx*dx+x1co*dx+x0co);
		Destroy (gameObject,vanishtime);
	}
}
