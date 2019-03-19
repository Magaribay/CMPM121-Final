using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDMG : MonoBehaviour
{

    public GameObject player;
    public int spikeDmg = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            
            player.GetComponent<Damage>().TakeDamage(spikeDmg);
        }
    }

}
