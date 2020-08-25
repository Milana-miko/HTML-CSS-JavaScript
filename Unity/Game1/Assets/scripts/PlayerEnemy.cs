using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using System.Xml.Serialization;
[System.Serializable]
public class Saveclass{
	public int Hearts;
	public Vector3[] Player1_Pos = new Vector3[10] ;
	public int levels;
	public int points;
}

[System.Serializable]
public class TestPlayer
{
	public Image Hearts;
	public Vector3[] Player1_Pos = new Vector3[10];
	public Button levels;
}
public class PlayerEnemy : MonoBehaviour {
//	public TestPlayer[] testPlayer;
	public GameObject Player1;
	public GameObject[] Enemys;
	public GameObject posParent;
	public Transform[] enemypos;
	public GameObject[] Hearts;
	public int Speed = 30;
	public int Jump = 16;
	public bool Jumping = false;
	public Rigidbody2D rb;
	public int life;
	private int _count;
	public int Ins_speed;
	private GameObject obj;
	public GameObject _Start;
	public GameObject Game_Over;
	bool stop_inst_enemys = true;
	public GameObject Save_Button;
	public GameObject Esc_Button;
	int enemicount = 5;
	public SpriteRenderer mySpriteRenderer;
	public Text points_text;
	public int points = 0;
	Animator anim;
	public AudioSource forest_sounds;
	public ParticleSystem ps;
	public string text;
	private bool move;



	void StartAwake() {
		anim = GetComponent<Animator>();
		_Start = GameObject.Find("Start_Menu");
		mySpriteRenderer = GetComponent<SpriteRenderer>();
		forest_sounds.Play();
	}


	public void Save ()
	{
		var xml = new XmlSerializer (typeof(Saveclass));
		var SC = new Saveclass ();
		SC.Hearts = Hearts.Length;
		SC.levels = Global.level1;
		SC.Player1_Pos[Global.level1] = transform.position;
		SC.points = points;
	if (!Directory.Exists (Application.dataPath + "/save"))
		Directory.CreateDirectory (Application.dataPath + "/save");
		using (var stream = new FileStream (Application.dataPath + "/save/saver.xml", FileMode.Create, FileAccess.Write)) {
		xml.Serialize (stream, SC);
	}
	}


	public void LoadGame() {

		print("SC.Player1_Pos");
		var xml = new XmlSerializer(typeof(Saveclass));
		var SC = new Saveclass();
		if (File.Exists(Application.dataPath + "/save/saver.xml")) {
			using (var stream = new FileStream(Application.dataPath + "/save/saver.xml", FileMode.Open, FileAccess.Read)) {
				SC = xml.Deserialize(stream) as Saveclass;
			}
			if (!Global.next_level_portal) {
				transform.position = SC.Player1_Pos[Global.level1];
			}
			Global.next_level_portal = false;
			life = 3 - SC.Hearts;
			for (int i = 0; i < SC.Hearts; i++) {
				Hearts[i].SetActive(false);
			}

			points = SC.points;
			points_text.text = points.ToString();
		}
	}  

	void Start() {

	//	string tt = "55";

	//	points = int.Parse(tt);

		text = Global.play[2];
		StartCoroutine (LH ());
		//	_count = posParent.transform.childCount;
		//	enemypos = new Transform[_count];
		Game_Over.SetActive(false);
		Save_Button.SetActive(false);
		Esc_Button.SetActive(true);
		mySpriteRenderer.flipX = false;
		anim = GetComponent<Animator>();
		ps = GetComponentInChildren<ParticleSystem>();
		ps.Stop();

		for (int i = 0; i < _count; i++) {
			enemypos[i] = posParent.transform.GetChild(i);

		}

		rb = GetComponent<Rigidbody2D>();

	}

	[System.Serializable]
	public class Position
	{
		public float x;
		public float y;
	}


	void OnCollisionEnter2D(Collision2D variable) {
		if (variable.gameObject.tag == "Ground") {
			Jumping = false;
			anim.SetTrigger("down");
		}
	}


	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Portal") {
			Global.next_level_portal = true;
			Global.level1++;
			Save();
			SceneManager.LoadScene(Global.level1);
		}
		if (col.gameObject.tag == "Enemy") {
			life--;
			if (life >= 0) {

				Hearts[life].SetActive(false);
				Destroy(col.gameObject);
				ps.Play();
				EnemyInstanc();

			} else
				Game_Over.SetActive(true);
		}
		if (col.gameObject.tag == "Money") {
			points += 1;
			Destroy(col.gameObject);
			points_text.text = points.ToString();
		}
	}
	public void _Quit()
    {
		Save();
		Application.Quit();
	}

	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			_Quit();
		}

		
		if (Input.GetKeyDown(KeyCode.S))
		{
			Save_Button.SetActive(true);
		 

			}

			if (Input.GetKeyDown(KeyCode.D)) {
				RR();

			}
			if (Input.GetKeyDown(KeyCode.A)) {
				LL();

			}
			if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A)) {
				_Up();
			}
			if (Input.GetKeyDown(KeyCode.Space)) {
				OnClickJump();
			}


		}


		public void LL()
		{
			mySpriteRenderer.flipX = true;
			if (!move)
			{
				move = true;
				StartCoroutine(moveing(Vector3.left));
			}
			anim.SetBool("run", true);

		}
		public void RR()
		{
			mySpriteRenderer.flipX = false;
			if (!move)
			{
				move = true;
				StartCoroutine(moveing(Vector3.right));
			}
			anim.SetBool("run", true);

		}
		IEnumerator moveing(Vector3 dir)
		{
			while (move)
			{
				transform.Translate(dir * Time.deltaTime * Speed);
				yield return null;
			}

		}
		public	void _Up() {
			anim.SetBool("run", false);
			print("UP");
			move = false;
		}

		void OnClickJump()
		{
			if (Jumping == false) {
				Jumping = true;
				rb.velocity = new Vector2(0, Jump);
				anim.SetTrigger("jump");
				print("JUMP");
			}
		}
		IEnumerator LH() {
			while (enemicount > 0) {
				enemicount--;
				if (life < 1) {
					stop_inst_enemys = false;
				}

				float x = transform.position.x;

				yield return new WaitForSeconds(1);
				EnemyInstanc();

			}
		}
		/*IEnumerator Rmove()
		{
		right = true;
			while (right)
			{
			RightButtonDown();
			}
		}*/

		void EnemyInstanc() {
			GameObject enemy = Instantiate(Enemys[Random.Range(0, 4)], enemypos[enemicount].position, Quaternion.identity);
		}
	}



