using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    public GameObject video;
    public GameObject rawImage;
    public GameObject uiGame;

    void Start()
    {
        video.SetActive(true);
        rawImage.SetActive(true);
        uiGame.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            video.SetActive(false);
            rawImage.SetActive(false);
            uiGame.SetActive(true);
        }
    }
}
