using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosion;
    Rigidbody rb;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(exp, 5);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start() => rb = GetComponent<Rigidbody>();

    void LateUpdate() => transform.forward = rb.velocity;
}
