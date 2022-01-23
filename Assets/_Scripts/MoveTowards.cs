using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    private Collider _collider;
    [SerializeField] private float minRandomSpeed = 1;
    [SerializeField] private float maxRandomSpeed = 5;
    private float speed;
    void Start()
    {   speed = Random.Range(minRandomSpeed, maxRandomSpeed);
        _collider = GetComponent<Collider>();
    }

    void Update()
    {   Debug.Log(transform.position.ToString());
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
