using UnityEngine;
using System.Collections;

public class ParticleMovement : MonoBehaviour {
    Vector2 Velocity = new Vector2(0,1);
    [SerializeField] Rigidbody2D Particle;
	// Use this for initialization
	void Start () {
        Particle = GetComponent<Rigidbody2D>();
        Particle.velocity = Velocity;
        Particle.angularVelocity = 1;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0,0, transform.localEulerAngles.x + Random.Range(-10, 10)));
	}
}
