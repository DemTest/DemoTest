using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyInpup : MonoBehaviour {


    private Door m_door;
	// Use this for initialization
	void Start () {
        m_door = GameObject.Find("Dooroc").transform.GetComponent<Door>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward*0.1f, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * 0.1f, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * 0.1f, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * 0.1f, Space.Self);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        m_door.OpenDoor();
    }
    void OnTriggerExit(Collider other)
    {
        m_door.CloseDoor();
    }
}
