using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScriptVortex : MonoBehaviour
{


    public float scaleValue = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 5.0f * Time.deltaTime);
        transform.localScale += new Vector3(scaleValue * Time.deltaTime, scaleValue * Time.deltaTime, 0f);
    }



}
