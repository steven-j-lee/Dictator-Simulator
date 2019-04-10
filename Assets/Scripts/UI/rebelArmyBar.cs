using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rebelArmyBar : MonoBehaviour {
    public State state;
    public RectTransform rebels;
	public float maxValue; 
	public int index;
    
    public float maxLength;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float rebelWidth = maxLength * state.variables[index] / maxValue;
        rebels.sizeDelta = new Vector2(rebelWidth, rebels.sizeDelta.y);
        
        
        rebels.anchoredPosition = new Vector2(rebelWidth/2, rebels.anchoredPosition.y);
        
    }
}
