using UnityEngine;
using System.Collections;

public class ParticleMovement : MonoBehaviour {
    [SerializeField]
    float direction;
    [SerializeField]
    float velocity;
    [SerializeField]
    float vel;
    [SerializeField]
    float speed;
    [SerializeField] Rigidbody2D Particle;
	// Use this for initialization
	void Start () {
        Particle = GetComponent<Rigidbody2D>();
        StartCoroutine(AutoRotate());
        
    }
	
	// Update is called once per frame
	void Update () {
        velocity = Particle.velocity.x + Particle.velocity.y;
        vel = Mathf.SmoothDamp(vel, speed, ref velocity, speed/2, 0.5f);
        if(vel > 0.6)
        {
            vel = 0;
        }
        Particle.velocity = transform.up * vel;//Mathf.SmoothDamp(velocity, speed*20, ref velocity, Time.deltaTime * 6, 100); ;
        Particle.rotation = Mathf.SmoothDamp(Particle.rotation, direction, ref velocity, speed,100);
        
    }
    IEnumerator AutoRotate(){
        while (true)
        {
            speed = Random.Range(0.1f, 0.5f);
            direction = Random.Range(0f, 360f);
            yield return new WaitForSeconds(3);
        }
        
    }
}
