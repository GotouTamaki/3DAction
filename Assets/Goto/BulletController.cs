using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float _bulletSpeed = 1.0f;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward * _bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
