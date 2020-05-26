using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{

    public Material[] material;
    Renderer rend;
    bool isRouterOn;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        isRouterOn = false;

    }

    /*
    void OnMouseDown()
    {
        rend.material = material[1];

    }
    */

    void OnTriggerEnter(Collider player)
    {
        print("pierwszy");
        if (isRouterOn == false)
        {
            print("drugi");
            if (player.gameObject.tag == "cabel")
            {

                // Destroy(uiObject);
                //uiObject.SetActive(false);
                isRouterOn = true;
                print("ruter");
                rend.material = material[1];

                Destroy(player.gameObject);


            }
        }

    }
}
