using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // reducing health
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MainCharacterController.Instance.reducehealth(1);
            Debug.Log("Reduce Health");
            Debug.Log(MainCharacterController.Instance.getHealth());
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
