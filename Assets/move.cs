using UnityEngine;
using System.Collections;

public class example : MonoBehaviour
{
    public float speed = 2.0f;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //animator.SetFloat("Moving", 0.5f);
                self.transform.Translate(0f, 0f, 1f);
            }
            else
            {
                self.transform.Translate(0f, 0f, 0f);
            }

        }
    }
}