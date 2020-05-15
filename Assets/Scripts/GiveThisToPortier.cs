using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveThisToPortier : MonoBehaviour
{
    public GameObject colaCan;
    public GameObject door;
    public GameObject uiObject2;
    public GameObject portierInfo;

    public GameObject uiObject;
    private Animator _animator;

    void Start()
    {
        _animator = door.GetComponent<Animator>();
        //uiObject = GameObject.Find("portier");
        //uiObject.SetActive(false);
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
        
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "cola")
        {

           // Destroy(uiObject);
           uiObject.SetActive(false);
            Destroy(portierInfo);
            Destroy(uiObject);
            uiObject2.SetActive(true);
            OpenDoor();
            StartCoroutine("WaitForSec");


        }

    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(colaCan);
        Destroy(uiObject2);
       
        //Destroy(gameObject); info tylko raz

    }

    public void OpenDoor()
    {
        _animator.SetBool("open", true);
    }
}
