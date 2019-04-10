using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour {

    private AudioSource Source;
    public AudioClip SFX;
	// Use this for initialization
	void Start () {
        Source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        Source.PlayOneShot(SFX, 0.5f);
		
	}
}
