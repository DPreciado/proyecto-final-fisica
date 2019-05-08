using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HornetCloakOpacity : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    float opacityPower = 1f;

    [SerializeField]
    Slider sld_opacityAmount;

    private void Start()
    {
        render = GetComponent<Renderer>();
    }

    private void Update()
    {
        render.material.SetFloat("_Slider_Opacity", sld_opacityAmount.value);
    }
}
