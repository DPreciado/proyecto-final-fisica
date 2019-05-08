using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HornetEyesColor : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    float colorPower = 1f;

    [SerializeField]
    Slider sld_colorPower;

    private void Start()
    {
        render = GetComponent<Renderer>();
    }

    private void Update()
    {
        render.material.SetFloat("_Slider_Color", sld_colorPower.value);
    }
}
