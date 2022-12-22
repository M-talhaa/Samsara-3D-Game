using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    // public int coinCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MainCharacterController.Instance.addCoin();
            // adding health
            Debug.Log("You got a coin");
            Debug.Log(MainCharacterController.Instance.getCoinCount());

            // reducing health
            MainCharacterController.Instance.reducehealth(1);
            Debug.Log("Reduce Health");
            Debug.Log(MainCharacterController.Instance.getHealth());


            Destroy(this.gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
