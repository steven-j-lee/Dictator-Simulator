using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    public State state;
    public float[] impact;
    private AudioSource Source;
    public AudioClip SFX;

    public void happened()
    {
        Source = GetComponent<AudioSource>();
        bool canHappen = true;
        for (int x = 0; x < state.variables.Length; x++)
        {
            if(state.variables[x] + impact[x]< 0)
            {
                
                canHappen = false;
            }
        }

        if (canHappen)
        {
            Source.PlayOneShot(SFX, 0.5f);
            for (int x = 0; x < state.variables.Length; x++)
            {
				state.variables [x] += impact [x];
			}

		}
	}
}

