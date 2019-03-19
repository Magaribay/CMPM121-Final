using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Renderer[] child;
    public GameObject Player;
    public int arrowDMG = 10;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Player.GetComponent<Damage>().TakeDamage(arrowDMG);
            Unrender();

        }
        if (col.gameObject.tag == "Wall")
        {
            Unrender();
        }       
       
    }

    private void Unrender()
    {
        foreach (Renderer r in child)
        {
            r.enabled = false;
            Destroy(this.gameObject);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        child = this.GetComponentsInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
