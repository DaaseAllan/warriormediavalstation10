using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music_Controller : MonoBehaviour {

    public AudioClip menu, game;

    AudioSource source;

    float timer = 0;

    void Start()
    {
        source = GetComponent<AudioSource>();

        if(SceneManager.GetActiveScene().name == "Menu")
        {

            source.clip = menu;
        }
        else
        {
            source.clip = game;
        }


        source.Play();
    }

    void Update()
    {
        if(!source.isPlaying)
        {
            timer += Time.deltaTime;

            if (timer > 5)
                source.Play();
        }
    }

    void OnDestroyOnLoad()
    {
        Start();
    }
}
