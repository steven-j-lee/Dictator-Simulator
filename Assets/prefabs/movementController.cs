using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movementController : MonoBehaviour
{

    // Use this for initialization
    public Animator animator;
    public int stressIndicator;
    public float checkFrequency;
    // Update is called once per frame
    void Start()
    {
        Invoke("check", checkFrequency);

    }
    void check()
    {



        animator.SetTrigger("walk-idle");
        Invoke("check", checkFrequency);



        animator.SetTrigger("walk-run");




    }
    void Update()
    {
        if (Mathf.Abs(gameObject.GetComponent<Transform>().position.x) > Screen.width / 2)
        {
            Debug.Log("flipping animations");
            GetComponent<Transform>().localScale = new Vector3(-GetComponent<Transform>().localScale.x, GetComponent<Transform>().localScale.y, GetComponent<Transform>().localScale.z);

        }
    }
}
