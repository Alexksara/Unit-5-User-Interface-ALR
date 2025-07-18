using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] float forceMin = 12f;
    [SerializeField] float forceMax = 16f;
    [SerializeField] float torqueRange = 10f;
    [SerializeField] float spawnPos = 4f;
    [SerializeField] float spawnPosY = 2;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(RandomForce(),ForceMode.Impulse);
        rb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        this.transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked on object"); 
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(forceMin, forceMax);
    }

    private float RandomTorque()
    {
        return Random.Range(-torqueRange, torqueRange);
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-spawnPos, spawnPos), -spawnPosY);
    }
}
