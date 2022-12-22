using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    public Animator animator;
    public float speed = 2.0f;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetFloat("Moving", 0.5f);
        }
        else
        {
            animator.SetFloat("Moving", 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Right", true);
            //transform.Rotate(Vector3.up, 2.0f);
        }
        else {
            animator.SetBool("Right", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Left", true);
        }
        else
        {
            animator.SetBool("Left", false);
        }
    }
}
