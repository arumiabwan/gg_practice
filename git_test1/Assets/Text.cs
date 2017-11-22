using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour {


    //GameObject tapTex;
    int count = 0;


	// Use this for initialization
	void Start () {

        //tapTex.GetComponent<TextMesh>().text = "あるみにだよ";

        //gameObject.GetComponent<TextMesh>().text = tapTex.GetComponent<TextMesh>().text;

        gameObject.GetComponent<TextMesh>().text = string.Format("{0}",count);
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.T)) {


            count++;
            //gameObject.GetComponent<TextMesh>().text = "あるみにだよ";

        }

        //if (count == 1) gameObject.GetComponent<TextMesh>().text = "あるみにだよ";
        //else if(count==2) gameObject.GetComponent<TextMesh>().text = "文字列を";
        //else if (count == 3) gameObject.GetComponent<TextMesh>().text = "スクリプトファイルから";
        //else if (count == 4) gameObject.GetComponent<TextMesh>().text = "書き換えることが";
        //else if (count == 5) gameObject.GetComponent<TextMesh>().text = "できた！！！！";
        //else if (count >= 6) gameObject.GetComponent<TextMesh>().text = "わーい";

        gameObject.GetComponent<TextMesh>().text = string.Format("0{0}", count);

    }
}
