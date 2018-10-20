using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhaDai : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Debug.Log("hi   ");
	    Debug.Log("我在试试");
	}

   
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("lai");
        if (collision.gameObject.name=="Plane")
        {
           
            Destroy(this.gameObject);
        }
    }

}
