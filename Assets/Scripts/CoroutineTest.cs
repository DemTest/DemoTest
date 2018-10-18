using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    Debug.Log("1");
	    Debug.Log("2");
	    StartCoroutine("test");
	    Debug.Log("4");
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        StopCoroutine("test");//停止协程
            
	    }
	}

    IEnumerator test()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("$");
        yield return new WaitForSeconds(3);
        Debug.Log("$%");
    }

}
