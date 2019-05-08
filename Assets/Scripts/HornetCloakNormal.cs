using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HornetCloakNormal : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    float colorPower = 1f;

    [SerializeField]
    Slider sld_normalAmount;

    private void Start()
    {
        render = GetComponent<Renderer>();
    }

    private void Update()
    {
        render.material.SetFloat("_Slider_Normal", sld_normalAmount.value);
    }
}
