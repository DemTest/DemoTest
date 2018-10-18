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

	    InvokeRepeating("CreatCol", 5, 5);
	    

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreatCol()
    {
        for(int i=0;i<5;i++)
        { 
        GameObject col = GameObject.Instantiate(obj, new Vector3(Random.Range(-9.59f, 10.02f), -0.5f, Random.Range(-7.85f, 8.26f)), Quaternion.identity);
            col.transform.parent = tr;
            col.transform.Rotate(new Vector3(90, 0, 0));
        }
    }

    



}
