using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {



    private Transform m_transform;
	// Use this for initialization
	void Start ()
    {
        m_transform = gameObject.GetComponent<Transform>();
	}
	
    public void OpenDoor()
    {
        m_transform.Rotate(Vector3.up, -90);
    }
    public void CloseDoor()
    {
        m_transform.Rotate(Vector3.up, 90);
    }

	// Update is called once per frame
	void Update ()
    {
		
	}
}
