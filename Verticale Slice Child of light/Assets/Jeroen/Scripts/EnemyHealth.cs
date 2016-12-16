using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int health = 10;
	[SerializeField]
	private Animator Animator;
	[SerializeField]
	private GameObject Enemy;
	[SerializeField]
	private ParticleSystem _enemydeathpraticle;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Destroy (gameObject, 5f);
			Animator.SetFloat ("Death", 1f);
			Instantiate (_enemydeathpraticle, transform.position, transform.rotation);

		} 
	}
		
}
