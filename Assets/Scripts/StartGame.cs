using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public AudioSource source;

    private void Awake()
    {
        Time.timeScale = 0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Y))
        //{
        //    Time.timeScale = 1f;
        //    source.Play();
        //}
    }
}
