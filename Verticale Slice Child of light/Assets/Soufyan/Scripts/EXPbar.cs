using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EXPbar : MonoBehaviour
{
    [SerializeField] private Image _filledBar;
    [SerializeField] private float _fillSpeed;
    private float _amount = 0.01f;
    
	// Update is called once per frame
	void Update()
    {
        _filledBar.fillAmount = Time.time * _fillSpeed;
        _filledBar.fillAmount += _amount * _fillSpeed;

        if(_filledBar.fillAmount == 0.30f)
        {
            _filledBar.fillAmount += 0.60f;
        }
        else if(_filledBar.fillAmount == 1f)
        {
            _filledBar.fillAmount -= 0.1f;
        }
	}
}
