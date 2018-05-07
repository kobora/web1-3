using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test13 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int hp = 200;
        if(hp >= 100)
        {
            Debug.Log("攻撃!!");
 }else {
            Debug.Log("防御!!");
        }
		
	}
}
