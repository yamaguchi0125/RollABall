using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
        Debug.Log(transform.position);

        //transform.position = transform.position + new Vector3(1, 1, 1);
        //transform.position += new Vector3(1, 1, 1);
        transform.position += Vector3.one;//�g�����X�t�H�[����S��1�ɂ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
