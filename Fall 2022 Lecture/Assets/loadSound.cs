using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadSound : MonoBehaviour
{
    public AudioClip audioPlayer;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint (audioPlayer, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
