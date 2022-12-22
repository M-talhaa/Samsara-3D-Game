using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player")
        //{
            Debug.Log("You got a coin");
            Destroy(this.gameObject);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
