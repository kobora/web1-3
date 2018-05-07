using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test14 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int hp = 180;
        if (hp <= 50)
        {
            Debug.Log("逃走!");
        }else if (hp >= 200){
            Debug.Log("攻撃!");
        }
        else{
            Debug.Log("防御!");
        }
		
	}
}
