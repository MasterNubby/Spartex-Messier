using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScriptVortex : MonoBehaviour
{

    //Scales the float 
    [SerializeField] private float scaleValue = 0f;
       
    //Runs once if script component enabled and after Awake() methods
    void Start()
    {
       // transform.localScale += new Vector3(scaleValue * Time.deltaTime, scaleValue * Time.deltaTime, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 5.0f * Time.deltaTime);
        transform.localScale += new Vector3(scaleValue * Time.deltaTime, scaleValue * Time.deltaTime, 0f);
    }

}
