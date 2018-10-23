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
        if(Input.GetMouseButton(0))
        {
            //使用主摄像机创建一根射线，射线的方向是我们鼠标点击的位置。
           Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);
            //使用物理类检测射线的碰撞，并返回被碰撞物体的信息。
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
