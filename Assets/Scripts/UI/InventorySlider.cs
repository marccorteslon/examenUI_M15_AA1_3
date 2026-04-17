using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlider : MonoBehaviour
{

    [SerializeField] private Slider _slider;

    [SerializeField] private TextMeshPro _sliderText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            _sliderText.text = v.ToString("0.00");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
