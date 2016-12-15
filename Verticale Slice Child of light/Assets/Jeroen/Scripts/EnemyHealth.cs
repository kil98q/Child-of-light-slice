using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int health = 10;
	[SerializeField]
	private AudioSource _deathSounds;

	[SerializeField]
	private GameObject Enemy;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			//_deathSounds.Play ();
			//Enemy.SetActive (false);
			//Destroy (gameObject, 5f);
			PlaySound();
		} 
	}

	void PlaySound(){
		_deathSounds.Play();
		Debug.Log ("Aids");
	}
}
