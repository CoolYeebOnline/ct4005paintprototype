using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{

    public float explosionForce = 10;
    public float explosionRadius = 5;
    public float fuseCountdown = 3;


    private bool litFuse = false;
    

    // Update is called once per frame
    void Update()
    {
        if (litFuse)
        {
            fuseCountdown -= Time.deltaTime;

            if(fuseCountdown <= 0)
            {
                SelfDestruct();
            }
        }
    }
    public void LightFuse()
    {
        litFuse = true;
    }

    private void SelfDestruct()
    {
        Collider[]colliders = Physics.OverlapSphere(transform.position, 5f);
        foreach (Collider collider in colliders)
        {
            Rigidbody r = collider.GetComponent<Rigidbody>();
            if (r != null)
            {
                r.AddExplosionForce(explosionForce,transform.position, explosionRadius, 0, ForceMode.Impulse);
            }
        }

        Destroy(gameObject);
    }

}
