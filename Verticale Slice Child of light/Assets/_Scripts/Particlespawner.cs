using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Particlespawner : MonoBehaviour {
    public GameObject ParticlePrefab;
    GameObject Spawner;
    Vector3 SpawnerPos;
    public int ParticleAmount;
    public Vector3 SpawnRange;
    List<GameObject> Particles = new List<GameObject>();
	// Use this for initialization
	void Start () {
        SpawnerPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        RemoveParticlesOffscreen();
        if(Particles.Count < ParticleAmount)
        {
            SpawnParticle();
        }
	}

    void SpawnParticle()
    {
        GameObject NewParticle = Instantiate(ParticlePrefab);
        Particles.Add(NewParticle);
        NewParticle.transform.position = transform.position;
    }
    void RemoveParticlesOffscreen()
    {
        foreach(GameObject particlee in Particles)
        {
            if (particlee != null)
            {
                Vector3 _partPos = new Vector3(particlee.transform.position.x, particlee.transform.position.y, particlee.transform.position.z);
                print("Delete!");
                if (false)
                {
                    DestroyImmediate(particlee);
                }
                if (false)
                {
                    DestroyImmediate(particlee);
                }
                if (false)
                {
                    DestroyImmediate(particlee);
                }
            }
        }
    }
    
}
