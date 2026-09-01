using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesScript1 : MonoBehaviour
{


    public GameObject thisObject; // The object you want to place on the edge of the sphere
    public Transform vortextObject;
    public float obstacleMoveSpeed = 1f;
    public float rotationSpeed = 0f;


    public float sphereRadius = 60f;  // The radius of the sphere
    public Vector3 sphereCenter = Vector3.zero;  // The center of the sphere

    

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, vortextObject.position, obstacleMoveSpeed * Time.deltaTime);
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x >= 0 && transform.position.y >= 0 && collision.gameObject.tag == "Vortex")
        {

            PositionObjectOnSphere();

        }
        else if (transform.position.x >= 0 && transform.position.y < 0 && collision.gameObject.tag == "Vortex")
        {
            PositionObjectOnSphere();
        }
        else if (transform.position.x < 0 && transform.position.y > 0 && collision.gameObject.tag == "Vortex")
        {
            PositionObjectOnSphere();
        }
        else if (collision.gameObject.tag == "Vortex")
        {
            PositionObjectOnSphere();
        }

    }


    void PositionObjectOnSphere()
    {
        // Generate random angles for spherical coordinates
        float theta = Random.Range(0f, 2f * Mathf.PI);  // Azimuthal angle (0 to 2π)
        float phi = Random.Range(0f, Mathf.PI);        // Polar angle (0 to π)

        // Convert spherical coordinates to Cartesian coordinates (x, y, z)
        float x = sphereCenter.x + sphereRadius * Mathf.Sin(phi) * Mathf.Cos(theta);
        float y = sphereCenter.y + sphereRadius * Mathf.Cos(phi);
        float z = sphereCenter.z + sphereRadius * Mathf.Sin(phi) * Mathf.Sin(theta);

        // Position the object on the surface of the sphere
        thisObject.transform.position = new Vector3(x, y, z);
    }


}




