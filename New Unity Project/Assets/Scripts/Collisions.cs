using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int minProgress = 0;
    public int currentProgress;
    public GameObject nextTotem;

    public ProgressBar progressBar;

    public ParticleSystem soulsParticles;

    void Start()
    {
        currentProgress = minProgress;
        progressBar.SetMinProgress(minProgress);
        nextTotem.SetActive(false);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Player")
        {
            
            Destroy();

        }
    }

    void Destroy()
    {
        currentProgress += 1;
        progressBar.SetProgress(currentProgress);
        Instantiate(soulsParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
        nextTotem.SetActive(true);
    }


}
