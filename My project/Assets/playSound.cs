using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {

     source.volume = Mathf.Clamp01(collision.relativeVelocity.magnitude / 20);
     source.Play();
        
    }



}
