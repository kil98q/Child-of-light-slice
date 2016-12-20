using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public enum AttackModes{
	Normal = 0,

}
public class Attack : MonoBehaviour {
	[SerializeField]
	private Animator Anim;
	[SerializeField]
	private AttackModes Attackmode;
	[SerializeField]
	private int Damage;
	[SerializeField]
	private GameObject AttackSelector;
	[SerializeField]
	private AudioSource _knifesounds;
	private EnemyHealth _enemyHealth;
	private AudioSource Sound;
	[SerializeField]
	private AudioClip _deathSound;
	[SerializeField]
	private AnimationClip Animatie;
	private bool _swing;

	// Use this for initialization
	void Start () {
		_swing = false;
		Damage = 10;
		Anim = GetComponent<Animator>();
		_enemyHealth = GameObject.FindGameObjectWithTag ("Enemy").GetComponent<EnemyHealth> ();
		Sound = GetComponent<AudioSource> ();


		Anim.SetBool ("Attack", false);
		Anim.SetBool ("Idle", true);
		_swing = true;
	}




	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A) && _swing == false) 
		{
				switch (Attackmode) {
				case AttackModes.Normal:
					NormalAtt ();
				break;
			}
			Anim.SetBool ("Attack", true);
			Anim.SetBool ("Idle", false); 
			_swing = true;
		}

		if (_swing == true) 
		{
			StartCoroutine (AttackTimer ());
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel ("MainScene");
		}


	}


	void NormalAtt(){
		Sound.PlayOneShot(_deathSound, 1);
		_enemyHealth.health -= Damage;
		Debug.Log ("NormalAtt");
		Destroy (AttackSelector);
		_knifesounds.Play ();
		Debug.Log (_swing);


	}


	IEnumerator AttackTimer()
	{
		
		yield return new WaitForSeconds (Animatie.length);
		_swing = false;
		Anim.SetBool ("Attack", false);
		Anim.SetBool ("Idle", true);
		Debug.Log ("123");


	}






}









