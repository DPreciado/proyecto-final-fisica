using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HornetHeadOpacity : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    float OpacityPower = 1f;

    [SerializeField]
    Slider sld_OpacityPower;

    private void Start()
    {
        render = GetComponent<Renderer>();
    }

    private void Update()
    {
        render.material.SetFloat("_Slider_Opacity", sld_OpacityPower.value);
    }
}
