using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShell : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3);
    }
}
