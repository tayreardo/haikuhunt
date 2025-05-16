using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(FallTimer());
        }
    }


    IEnumerator FallTimer() 
    {
        GetComponent<CapsuleCollider2D> ().enabled = false;
        yield return new WaitForSeconds (0.165f);
        GetComponent<CapsuleCollider2D>().enabled = true;
    }

}
