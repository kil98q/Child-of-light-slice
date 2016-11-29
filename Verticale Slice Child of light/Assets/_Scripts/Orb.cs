using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Orb : MonoBehaviour {
    public float Current;
    public float Speed;
    public float Distance;
    public bool Enabled;
    public bool AutoMove;
    public bool AutoReset;
    public bool OrbBobbing;
    public float OrbBobbingOffset;
    public float OrbBobbingoriginal;
    public float startTime;
    public float OrbBobbingSpeed;
    bool OrbUp;
    Sprite CurrentSprite;
    Image ImageObject;
    public Sprite EnabledSprite;
    public Sprite DisabledSprite;
    float startingPosition;
	// Use this for initialization
	void Start () {
        startingPosition = transform.localPosition.x;
        ImageObject = GetComponent<Image>();
        CurrentSprite = ImageObject.sprite;
        OrbBobbingoriginal = transform.localScale.x;
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Enabled)
        {
            if (CurrentSprite != EnabledSprite)
            {
                CurrentSprite = EnabledSprite;
                ImageObject.sprite = CurrentSprite;
            }
            if (AutoMove)
            {
                if (transform.localPosition.x <= startingPosition + Distance)
                {
                    Current += (Distance / Speed);

                }
                else
                {
                    if (AutoReset)
                    {
                        Current = 0;
                    }
                }
            }
            if (OrbBobbing && !AutoMove)
            {
                float sizeToAdd;
                if (OrbUp&&transform.localScale.x> OrbBobbingoriginal+OrbBobbingOffset - 0.01f)
                {
                    startTime = Time.time;
                    OrbUp = !OrbUp;
                }
                if (!OrbUp && OrbBobbingoriginal + 0.01f> transform.localScale.x)
                {
                    startTime = Time.time;
                    OrbUp = !OrbUp;
                }
                if (OrbUp)
                {
                    sizeToAdd = Damping(transform.localScale.x, OrbBobbingoriginal + OrbBobbingOffset, OrbBobbingSpeed);
                }else
                {
                    sizeToAdd = Damping(transform.localScale.x, OrbBobbingoriginal, OrbBobbingSpeed);
                }
                
                transform.localScale = new Vector3(sizeToAdd, sizeToAdd,1);
            }
        }
        else
        {
            if (CurrentSprite != DisabledSprite)
            {
                
                CurrentSprite = DisabledSprite;
                ImageObject.sprite = CurrentSprite;
            }
            
        }
        transform.localPosition = new Vector3(startingPosition + Current, transform.localPosition.y, transform.localPosition.z);
    }
    float Damping(float currentRotation, float Target, float Speed)
    {
        return Mathf.SmoothStep(currentRotation, Target, (Time.time - startTime) / OrbBobbingSpeed);
    }
}
