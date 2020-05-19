using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{

    public Material[] material;
    Renderer rend;
    public GameObject cabel;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void OnMouseDown(Collider player)
    {
            if(player.gameObject.tag == "cabel"){
                print("Kabel click!");
                rend.material = material[1];
            }else{
                rend.material = material[0];
            }
    }
}
