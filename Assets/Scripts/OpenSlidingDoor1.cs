using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSlidingDoor1 : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "MC")
        {
            _animator.SetBool("open", true);
            //Destroy(colaCan);
           // StartCoroutine("WaitForSec");
            //_animator.SetBool("open", false);

        }

    }

    //IEnumerator WaitForSec()
   // {
        //yield return new WaitForSeconds(2);
       // Destroy(colaCan);
        //Destroy(gameObject); info tylko raz

    //}

}
