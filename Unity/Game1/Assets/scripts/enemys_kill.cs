using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemys_kill : MonoBehaviour {
	PlayerEnemy playerEnemy;
	void Start(){
		playerEnemy = FindObjectOfType<PlayerEnemy> ();
	}

	void OnTriggerEnter2D(Collider2D killenemy){
		if (killenemy.gameObject.tag == "Enemy") {
			Destroy (killenemy.gameObject);
			//playerEnemy.EnemyInstanc ();
		}
	}
}
