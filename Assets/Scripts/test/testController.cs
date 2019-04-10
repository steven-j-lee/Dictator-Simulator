using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testController : MonoBehaviour {
    public SpriteRenderer[] spriteColors;
    public State state;
    
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        for(int x = 0; x< state.variables.Length; x++)
        {
            Debug.Log(state.variables[x] / 100);
            spriteColors[x].color = new Color(1-(state.variables[x]/100), state.variables[x] / 100, 0);
        }
	}
}
