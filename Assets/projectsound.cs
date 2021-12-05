using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectsound : MonoBehaviour
{

    AudioSource audiosource;
    private void OnCollisionEnter2D(Collision2D other)
    {
        audiosource.Play();
    }

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
}