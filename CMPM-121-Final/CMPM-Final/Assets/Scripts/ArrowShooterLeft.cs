using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooterLeft : MonoBehaviour
{
    [SerializeField] private float timeToShoot;

    GameObject prefab;
    private float timer = 0.0f;
    GameObject projectile;
    private Rigidbody rb;
    private Quaternion projectileRotation;

    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        prefab = Resources.Load("WoodenArrowFinal") as GameObject;
        velocity = new Vector3(-20f, 0, 0);
        projectileRotation = Quaternion.Euler(-180, -90, 90);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeToShoot)
        {
            projectile = Instantiate(prefab);

            projectile.transform.position = transform.position + new Vector3(0, 0, 0);
            projectile.transform.rotation = projectileRotation;

            rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = velocity;
            timer = timer - timeToShoot;
        }
    }
}
