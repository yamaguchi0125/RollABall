using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumBlock : MonoBehaviour
{
    public float Amplitude = 5f; //�U��
    public float Frequency = 1f; //�p�x
    private Vector3 startPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPos + Vector3.forward * Amplitude * Mathf.Sin(Time.time * Frequency);
    }
}
