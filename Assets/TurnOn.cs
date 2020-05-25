using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{

    public Material[] material;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
    

    void OnMouseDown()
    {
        rend.material = material[1];

    }

    public void OnCabel()
    {
        rend.material = material[1];

    }
}
