using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour {

    public GameObject first;//申明GameObject变量 用来保存第一个界面
    public GameObject second;//申明GameObject变量 用来保存第二个界面

    //显示第二个界面的方法
    public void next()
    {

        first.SetActive(false);//隐藏第一个界面
        second.SetActive(true);//显示第二个界面
    }

    //显示第一个界面的方法
    public void back()
    {
        first.SetActive(true);//显示第一个界面
        second.SetActive(false);//隐藏第二个界面
    }

    
}
