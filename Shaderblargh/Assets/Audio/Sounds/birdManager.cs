using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdManager : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            source.PlayOneShot(sound1, 1);
        }
        if (Input.GetKeyDown("2"))
        {
            source.PlayOneShot(sound2, 1);
        }
        if (Input.GetKeyDown("3"))
        {
            source.PlayOneShot(sound3, 1);
        }
        if (Input.GetKeyDown("4"))
        {
            source.PlayOneShot(sound4, 1);
        }
    }
}
