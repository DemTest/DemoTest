using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //private GameObject _Object;
	// Use this for initialization
	void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update ()
	{
	    MovePlayer();

	}


    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward*Time.deltaTime*4,Space.World);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(Vector3.down*3);
            transform.Translate(Vector3.left * Time.deltaTime * 4, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Rotate(Vector3.up*3);
            transform.Translate(Vector3.right * Time.deltaTime * 4, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 4, Space.World);
        }

    }


    

}
