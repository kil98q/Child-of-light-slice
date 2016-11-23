using UnityEngine;
using System.Collections;

public class Screenshake : MonoBehaviour
{
    [SerializeField] private Transform _cameraTransform;                //Transform pakt de camera object
    [SerializeField] private float _shakeDur = 0;                       //hoe lang de camera moet shaken
    [SerializeField] private float _shakeAmount = 0;                    //amplitude van de shake
    [SerializeField] private float _shakeDecrease = 0;                  //het tijd duur verlagen

    private Vector3 _originalPos;                                       //positie camera is (0,0,0)

	// Use this for initialization
	void Awake ()
    {
        if(_cameraTransform == null) //positie camera is 0
        {
            _cameraTransform = GetComponent<Transform>(); //component ophalen van Transform
        }
	}

    void OnEnable()
    {
        _originalPos = _cameraTransform.localPosition; //originele positie wordt de positie van de camera
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(_shakeDur > 0) //als de shake duratie hoger is dan 0
        {
            //gaat terug naar een random positie in de radius van 1
            _cameraTransform.localPosition = _originalPos + Random.insideUnitSphere * _shakeAmount; 
            _shakeDur -= Time.deltaTime * _shakeDecrease; //het verlagen van de screen shake
        }
        else //als de shake NIET hoger is dan 0
        {
            _shakeDur = 0; //shake duratie wordt 0
            _cameraTransform.localPosition = _originalPos; //de camera positie gaat terug naar (0,0,0)
        }
	}
}
