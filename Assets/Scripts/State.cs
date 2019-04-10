using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State : MonoBehaviour
{
    public Text score;
    public Text money;
    public Text army;
    public Text respect;
    public Text taxes;
    public Text information;
    public Text rebel;
	public Animator animator;
    public int deaths = 0;
	public enum variableNames { money, economy, population, taxes, awareness, army, rebels, respect };
	public float[] variables;
	public float respect_modifier;
	public float awareness_modifier;
	public float taxes_modifier;
	public float Economy_modifier;
	public float economyBoost;
	public float taxes_respect_modifier;
    public float respect_info_modifier;
    public float battleSize;
    public float taxesIncome;
	bool something;
    public AudioSource Source;
    public AudioSource Over;
    public AudioClip GameOver;
	/*public float popEffect;
public float respectEffect;
public float informationEffect;
//when not specified, effect is to rebels
public float taxes_respectModifier;
public float respect_informationModifier;
public int popGrowth = 1000;


public int state = 1;
public float economy_boost = 0;
float setEconomy;
float economy_difference;
float kp_economy = 0.0005f;
float rebel_growth;
float base_growth;
float fearRebelLoss;
*/

	// Use this for initialization
	void Start()
	{
		something = true;
        Invoke("battle", 4F);

	}

	// Update is called once per frame
	void Update()
	{
		
		if (something && variables[(int)variableNames.rebels] >= variables[(int)variableNames.army])
		{
            Source.Stop();
			something = false;
			animator.SetTrigger("gameOver");
            Source.PlayOneShot(GameOver, 0.5f);

        }
        variables[(int)variableNames.money] += variables[(int)variableNames.taxes] * taxesIncome;
        //variables[(int)variableNames.economy] = variables[(int)variableNames.population] * Economy_modifier + economyBoost;
        if ((variables[(int)variableNames.respect] - variables[(int)variableNames.taxes] * taxes_respect_modifier + variables[4] * respect_info_modifier) > 0 || (variables[(int)variableNames.respect] - variables[(int)variableNames.taxes] * taxes_respect_modifier + variables[4] * respect_info_modifier)< 100)
        {
            variables[(int)variableNames.respect] -= variables[(int)variableNames.taxes] * taxes_respect_modifier - variables[4]*respect_info_modifier;
        }
        variables[(int)variableNames.rebels] += (100-variables[(int)variableNames.respect] )* respect_modifier + (100 - variables[(int)variableNames.awareness] )* awareness_modifier + variables[(int)variableNames.taxes] * taxes_modifier;

        rebel.text = "" + variables[6];
        army.text = "" + variables[5];
        respect.text = "" + variables[7];
        taxes.text = "" + variables[3];
        money.text = "" + variables[0];
        information.text = "" + variables[4];
		
	}
    void battle()
    {
        Invoke("battle", 2F);
        if(variables[5] > battleSize && variables[6] > battleSize)
        {
            if (something)
            {
                deaths += (int)battleSize * 2;
                variables[5] -= battleSize;
                variables[6] -= battleSize;
                score.text = "Kill score: " + deaths;
            }
        }
    }
}

