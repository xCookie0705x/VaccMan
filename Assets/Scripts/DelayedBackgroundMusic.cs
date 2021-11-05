using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DelayedBackgroundMusic : MonoBehaviour
{

    AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        backgroundMusic.PlayDelayed(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
