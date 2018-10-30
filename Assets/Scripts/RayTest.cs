using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    RaycastHit hit;
	void Update ()
	{
	    ray();

	}

    void ray()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);           

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "gold")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
        

    }

}
