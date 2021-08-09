using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource color;
    
    // Start is called before the first frame update
    void Start()
    {
        //color.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) )
        {
            color.Play();
        }
    }
}
