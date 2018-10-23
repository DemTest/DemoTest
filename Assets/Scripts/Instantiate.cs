using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{

    public GameObject obj;
    public Transform tr;
    
	// Use this for initialization
	void Start ()
	{

	    InvokeRepeating("CreatCol", 1, 1f);

	    

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreatCol()
    {
       
        GameObject col = GameObject.Instantiate(obj, new Vector3(Random.Range(-10.07f, 10.58f), 15.36f, Random.Range(9.66f, 14.19f)), Quaternion.identity);
            col.transform.parent = tr;
            //col.transform.Rotate(new Vector3(90, 0, 0));
        
    }

    



}
