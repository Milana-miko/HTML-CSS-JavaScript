using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level_2 : MonoBehaviour {


	public GameObject Player1;
	public GameObject[] Enemys;
	public GameObject[] Hearts;
	public int Speed = 40;
	public int Jump = 20;
	public bool Jumping=false;
	public Rigidbody2D rb;
	public int life;
	private int _count;
	private GameObject obj;
	public GameObject Save_Button;
	int enemicount = 5;
	public SpriteRenderer mySpriteRenderer;
	public Text points_text;
	public int points = 0;
	Animator anim; 
	public AudioSource forest_sounds;




	void StartAwake (){
		anim = GetComponent <Animator>();
		mySpriteRenderer = GetComponent<SpriteRenderer>();
		forest_sounds.Play ();
	}

		

	void Start () {
	//	Save_Button.SetActive (false);
		mySpriteRenderer.flipX = false;
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();

	}

	[System.Serializable]
	public class Position
	{
		public float x;
		public float y;
	}

	void OnCollisionEnter2D (Collision2D variable){
		if(variable.gameObject.tag == "Ground"){ 
			Jumping = false;
			anim.SetTrigger ("down");
		} 
	} 
	private void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Enemy") {
			life--;
			if (life >= 0) {

				Hearts [life].SetActive (false);
				Destroy (col.gameObject);

			}
		//	else
		//	Game_Over.SetActive (true);
		}
		if (col.gameObject.tag == "Money") {
			points += 1;
			Destroy (col.gameObject);
			points_text.text = points.ToString();  
		}
	}


	void Update ()
	{

		if (Input.GetKey("escape"))
		{
			Application.Quit ();
		}

		if (Input.GetKey (KeyCode.S))
		{
		Save_Button.SetActive (true);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(Vector3.right * Time.deltaTime * Speed);
			mySpriteRenderer.flipX = false;
			anim.SetBool ("run", true);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(Vector3.left * Time.deltaTime * Speed);
			mySpriteRenderer.flipX = true;
			anim.SetBool ("run", true);

		}
		if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)) {
			anim.SetBool ("run", false);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			print ("JUMP");
			if (Jumping == false) { 
				Jumping = true; 
				rb.velocity = new Vector2 (0 ,Jump);
				anim.SetTrigger ("jump");
			} 
		} 

				float x = transform.position.x;
		
	}

}
