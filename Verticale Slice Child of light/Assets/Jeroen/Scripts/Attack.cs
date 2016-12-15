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


	//Animator anim;

	private EnemyHealth _enemyHealth;
	// Use this for initialization
	void Start () {
		
		Damage = 10;
		Anim = GetComponent<Animator>();
		_enemyHealth = GameObject.FindGameObjectWithTag ("Enemy").GetComponent<EnemyHealth> ();


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			switch (Attackmode) {
			case AttackModes.Normal:
				NormalAtt ();
				break;
			}
		}
	}

	void NormalAtt(){
		_enemyHealth.health -= Damage;
		Debug.Log ("NormalAtt");
		Anim.SetFloat ("Start", 1f);
		Destroy (AttackSelector);
		_knifesounds.Play ();

	}
	



}









