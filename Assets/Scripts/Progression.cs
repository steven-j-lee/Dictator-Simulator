using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progression : MonoBehaviour
{
    public float probability;
	public Animator sharknado;
	public Animator terrorist;
    private AudioSource Source;
    public AudioClip disaster;
    public AudioClip attack;
    // Use this for initialization
    void Start ()
    {
        Source = GetComponent<AudioSource>();
    }
	
	// Update is 
	void Update ()
    {

		if (probability > Random.Range (0, 2000))
	    {
            Source.PlayOneShot(disaster, 0.5f);
            sharknado.SetTrigger ("shark");
			sharknado.GetComponent < Events > ().happened ();
	    }
		if (probability > Random.Range (0, 2000))
		{
            Source.PlayOneShot(attack, 0.5f);
            terrorist.SetTrigger ("terrorist");
			terrorist.GetComponent < Events > ().happened ();
		}
	
    }
}