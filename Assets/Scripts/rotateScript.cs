using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 360.0f * Time.deltaTime);
        transform.localScale += new Vector3(0.02f * Time.deltaTime, 0.02f * Time.deltaTime, 0f);
    }
}
