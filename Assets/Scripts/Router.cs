using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Router : MonoBehaviour
{
    TurnOn turnOn;
    
    public bool isRouterOn;

    void Start()
    {
        isRouterOn = false;
        print("ruter wylaczony");

    }

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
                turnOn.OnCabel();
                
                //Destroy(player.gameObject);


            }
        }

    }


}
