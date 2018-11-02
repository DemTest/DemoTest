using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if(this.gameObject .transform.position.y<-1)
        {
            Destroy(gameObject);
        }
	}
}
