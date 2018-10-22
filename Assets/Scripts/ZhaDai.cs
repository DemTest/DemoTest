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

<<<<<<< HEAD
	    Debug.Log("hi  你好，我的git ");
        Debug.Log("bwsnbb测试");

	    Debug.Log("hi   ");
	    Debug.Log("我在试试");
=======
	    Debug.Log("hi   ");
	    Debug.Log("我在试试");

	    Debug.Log("hi  你好，我的git ");
        Debug.Log("bwsnbb测试");

	    Debug.Log("hi  你好，我的git ");
        Debug.Log("bwsnbb测试");
>>>>>>> 04a531ae282027b0ab1ee297b201a91abdf10a45
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
