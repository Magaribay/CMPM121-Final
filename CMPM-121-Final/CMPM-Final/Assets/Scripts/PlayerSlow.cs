using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlow : MonoBehaviour
{
    public GameObject playerr;
    public int slowTimer = 0;
    public int slowDuration = 90;
    private bool hit;
    // Start is called before the first frame update

    void Start()
    {
        //hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            slowTimer = slowDuration;
            hit = false;
        }

        if (slowTimer > 1)
        {
            playerr.GetComponent<Movement>().SetSlowSpeed();
            slowTimer--;
            Debug.Log("slow for:" + slowTimer);

        }
        if(slowTimer <= 0)
        {
            playerr.GetComponent<Movement>().ResetSpeed();
        }

        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log(playerr.GetComponent<Movement>().moveSpeed);
            hit = true;
            Debug.Log(hit);
        }

    }
}
