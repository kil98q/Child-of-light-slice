using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarProgress : MonoBehaviour
{
    [SerializeField] private float _barDisplay;
    [SerializeField] private Image _filledBar;
    [SerializeField] private float _fillSpeed = -0.01f;
    private float _min = 0.01f;
    
    // Update is called once per frame
    void Update()
    {
        _filledBar.fillAmount -= _min * _fillSpeed;
        _barDisplay = Time.time * -_fillSpeed;
        
        if(_filledBar.fillAmount < 0.8f)
        {
            _filledBar.fillAmount = 0.8f;
        }

    }
}