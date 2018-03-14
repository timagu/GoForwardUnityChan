using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBGM : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        GetComponent<AudioSource>().volume = 1;
    }
}
