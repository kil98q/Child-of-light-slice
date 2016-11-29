using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EXPbar : MonoBehaviour
{
    [SerializeField] private float _barDisplay;
    [SerializeField] private Image _filledBar;
    [SerializeField] private float _fillSpeed;
    private float _min = 0.01f;
	
	// Update is called once per frame
	void Update ()
    {
        _filledBar.fillAmount += _min * _fillSpeed;
        _barDisplay = _fillSpeed * Time.time;

        if(_barDisplay > 0.35)
        {
            _filledBar.fillAmount = 0.9f;
        }
	}
}
