using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] float forceMin = 12f;
    [SerializeField] float forceMax = 16f;
    [SerializeField] float torqueRange = 10f;
    [SerializeField] float spawnPos = 4f;
    [SerializeField] float spawnPosY = 6;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        rb.AddTorque(Random.Range(-torqueRange, torqueRange), Random.Range(-torqueRange, torqueRange), Random.Range(-torqueRange, torqueRange),ForceMode.Impulse);

        this.transform.position = new Vector3(Random.Range(-spawnPos, spawnPos), -spawnPosY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
