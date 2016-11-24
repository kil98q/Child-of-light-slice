using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public enum WeaponTypes{
	Normal = 0,

}
public class Attack : MonoBehaviour {
	[SerializeField]
	private Animator Anim;
	[SerializeField]
	private WeaponTypes weaponType;
	[SerializeField]
	private int Damage = 10;

	private EnemyHealth _EnemyHealth;
	// Use this for initialization
	void Start () {
		_EnemyHealth = GameObject.FindGameObjectWithTag ("Enemy").GetComponent<EnemyHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			switch (weaponType) {
			case WeaponTypes.Normal:
				NormalAtt ();
				break;
	

			}
		}

			//Anim.Play ();
		
	
	}
	void NormalAtt(){
		Debug.Log ("NormalAtt");
	}


}


