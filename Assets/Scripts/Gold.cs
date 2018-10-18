using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    
    private Rigidbody _rigidbody;
    private Text text;
    
	 //Use this for initialization
	void Start ()
	{
	    _rigidbody= gameObject.GetComponent<Rigidbody>();
	    text=GameObject.Find("chengji").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.Rotate(Vector3.forward,5f);
	    
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("fagreaga");
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log(other.gameObject.tag);
            //Debug.Log("fagreaga");
            _rigidbody.AddForce(new Vector3(0,60,0));
            Invoke("Destroy", 1.2f);
            
            AddScore();
        }
    }

    void AddScore()
    {
        int s = int.Parse(text.text);

        text.text = (s + 1).ToString();
    }

    void Destroy()
    {
        Destroy(gameObject);
    }

    

}
