using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArBrick : MonoBehaviour {

    public GameObject brick;//墙壁预制体
    private Ray ray;
    RaycastHit hit;
    public GameObject bullet;//子弹预制体
    Rigidbody rigid;
    public Transform brickParent;
    // Use this for initialization
    void Start() {
        CreateBrick();
        
    }

    // Update is called once per frame
    void Update() {
        shot();
    }

    /// <summary>
    /// 生成墙壁
    /// </summary>
    void CreateBrick()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                GameObject _Brick= Instantiate(brick, new Vector3(i, j, 0), Quaternion.identity);
                _Brick.transform.parent = brickParent;

            }
        }
    }

    /// <summary>
    /// 保存射线，并发送子弹
    /// </summary>
    void shot()
    {

        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit))
            {
                
                GameObject _bullet= Instantiate(bullet, this.transform.position, Quaternion.identity);
                Vector3 point = hit.point - this.transform.position;//子弹发射方向
                _bullet.GetComponent<Rigidbody>().AddForce(point * 100);
            }
        }
        


    }

}
