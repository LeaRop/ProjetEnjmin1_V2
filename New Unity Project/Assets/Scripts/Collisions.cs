using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int value = 0;
    public int currentProgress;
    public GameObject nextTotem;

    public ProgressBar progressBar;

    public ParticleSystem soulsParticles;

    private AudioSource aSource;

    void Start()
    {
        currentProgress = value;
        progressBar.SetProgress(value);
        nextTotem.SetActive(false);
        aSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Player")
        {
            currentProgress += 1;
            progressBar.SetProgress(currentProgress);
            aSource.Play();
            Destroy();

        }
    }

    void Destroy()
    {
        
        Instantiate(soulsParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
        nextTotem.SetActive(true);
    }


}
