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
	[SerializeField]
	private Sprite Sword;
	[SerializeField]
	private Sprite attackmodes;
	//Animator anim;

	private EnemyHealth _enemyHealth;
	// Use this for initialization
	void Start () {
		

		Anim = GetComponent<Animator>();
		//_enemyHealth = GameObject.FindGameObjectWithTag ("Enemy").GetComponent<EnemyHealth> ();

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
	}

	void NormalAtt(){
		Debug.Log ("NormalAtt");
		Anim.SetFloat ("Start", 1f);
		DestroyImmediate (Sword, true);
		DestroyImmediate (attackmodes, true);

	}
	



}









