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

	    InvokeRepeating("CreatCol", 1, 2);
	    

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreatCol()
    {
        for(int i=0;i<3;i++)
        { 
        GameObject col = GameObject.Instantiate(obj, new Vector3(Random.Range(-6.35f, 8.38f), 15.36f, Random.Range(-6.58f, 5.67f)), Quaternion.identity);
            col.transform.parent = tr;
            //col.transform.Rotate(new Vector3(90, 0, 0));
        }
    }

    



}
