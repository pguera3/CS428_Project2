using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Interrupt : MonoBehaviour   
{
    public Animator animator;
    public GameObject button;
    AudioSource voice;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        voice = GetComponent<AudioSource>();
        button = GameObject.Find("Button");

        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("pressedButton", false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vButton)
    {
        animator.SetBool("pressedButton", true);
        voice.Play();
        Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vButton)
    {
        animator.SetBool("pressedButton", false);
        //animator.SetBool("pressedButton", true);
        //voice.Play();
        Debug.Log("Released");

    }
}
