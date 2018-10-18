using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	// Use this for initialization

    private AudioSource backGroundMusic;
    private bool musicPlay = true;//定义播放状态

    void Start()
    {
        //获取AudioSource组件
        backGroundMusic = gameObject.GetComponent<AudioSource>();
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        //播放与暂停
        if (Input.GetKeyDown(KeyCode.F10))
        {
            if (musicPlay == true)
            {
                backGroundMusic.Pause();
                musicPlay = false;
            }
            else
            {
                backGroundMusic.Play();
                musicPlay = true;
            }
        }

        //停止播放
        if (Input.GetKeyDown(KeyCode.F11))
        {
            backGroundMusic.Stop();
            musicPlay = false;
        }

        backGroundMusic.volume=0.5f;
    }
}
