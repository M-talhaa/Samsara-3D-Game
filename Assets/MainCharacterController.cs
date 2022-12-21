using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    public Animator animator;

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
        else {
            animator.SetFloat("Moving", 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Right", true);
        }
        else {
            animator.SetBool("Right", false);
        }

    }
}
