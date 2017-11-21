using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addcoinscript2 : MonoBehaviour
{

    public Transform Basecoin2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.X))
        {

            Vector3 offset = new Vector3(0, 0, 1);

            Instantiate(Basecoin2, transform.position, transform.rotation);

        }

    }
}
