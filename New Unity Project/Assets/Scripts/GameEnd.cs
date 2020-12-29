using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public GameObject endText;
    

    void Start()
    {
        
        endText.SetActive(false); 
    }


    void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Player")
        {
            
            endText.SetActive(true);
        }
    }
}
