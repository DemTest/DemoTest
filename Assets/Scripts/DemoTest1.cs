using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoTest1 : MonoBehaviour {

    private Rigidbody m_rigidbody;
    private Transform m_transform;
    // Use this for initialization
    void Start()
    {
        m_rigidbody = gameObject.GetComponent<Rigidbody>();
        m_transform = gameObject.GetComponent<Transform>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            m_rigidbody.MovePosition(m_transform.position+Vector3.forward*0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.back * 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.right * 0.1f);
        }
    }


}
