using UnityEngine;
using System.Collections;

public class TreeBreathingMotion : MonoBehaviour {
    [SerializeField]
    float degreesBreathing = 10;
    [SerializeField]
    float startingRotation;
    [SerializeField]
    float degrees = 0;
    [SerializeField]
    bool RotationRight = true;
    [SerializeField]
    float startTime;
    [SerializeField]
    float duration;
    // Use this for initialization
    void Start () {
        startingRotation = transform.localEulerAngles.z;
        startTime = Time.time - Random.Range(1,15);
        duration = Random.Range(40,50);

	}
	
	// Update is called once per frame
	void Update () {
        if (RotationRight)
        {
            transform.localEulerAngles = new Vector3(0, 0, Damping(transform.localEulerAngles.z, startingRotation + degreesBreathing, duration));
            if (Mathf.Abs(transform.localEulerAngles.z) > Mathf.Abs(startingRotation+ degreesBreathing) - 0.5)
            {
                startTime = Time.time;
                RotationRight = !RotationRight;
            }
        }
        else
        {
            transform.localEulerAngles = new Vector3(0, 0, Damping(transform.localEulerAngles.z, startingRotation, duration));
            if (Mathf.Abs(transform.localEulerAngles.z) < Mathf.Abs(startingRotation)+0.5)
            {
                startTime = Time.time;
                RotationRight = !RotationRight;
            }
        }
	}
    float Damping(float currentRotation,float Target,float Speed)
    {
        return Mathf.SmoothStep(currentRotation, Target, (Time.time - startTime) / Speed);
    }
    
}
