using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RotationMovement : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 1.0f;
    [SerializeField] private Transform rotateAround;

    public Transform object1; //Assign this in the inspector
    public Transform object2; //Assign this in the inspector
    public Transform playerTransform;


    public Image StaminaBar;


    public float moveSpeed = 0f;
    public float Stamina, MaxStamina;
    public float RunCost;
    public float ChargeRate;
    public float waitSeconds = 1;


    void Update()
    {

        //Calculate the displacement vector
        Vector3 displacement = object1.position - object2.position;

        //Calculate the absolute distance (magnitude) as a float. You are basically converting that displacement vector to the float for the movespeed.
        float absoluteDisplacement = Mathf.Abs(displacement.magnitude);

        //Optionally, you can print or use the displacement value. This is basically just printing it.
        

        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, ((absoluteDisplacement * 0.5f) - moveSpeed) * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) && Stamina > 0)
        {
            moveSpeed = 10f;
            Stamina -= RunCost * Time.deltaTime;
            if (Stamina < 0)
            {
                Stamina = 0;

            }

            if (Stamina > 100)
            {
                Stamina = 100;

            }

            StaminaBar.fillAmount = Stamina / MaxStamina;
        }


       else
        {
            moveSpeed = 0f;

            if (Stamina > 100)
            {
                Stamina = 100;

            }

            if (Stamina <= 5)
            {
                StartCoroutine("WaitAndPrint");
            }

                StaminaBar.fillAmount = Stamina / MaxStamina;
        }




        if (Input.GetKey(KeyCode.A))
        {
            this.transform.RotateAround(rotateAround.position, Vector3.forward, rotationSpeed * 5 * Time.deltaTime);


        }


        if (Input.GetKey(KeyCode.D))
        {
            this.transform.RotateAround(rotateAround.position, Vector3.forward, -rotationSpeed * 5 * Time.deltaTime);


        }



    }


    // Coroutine that waits for 2 seconds
    IEnumerator WaitAndPrint()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(waitSeconds);
        Stamina += ChargeRate * Time.deltaTime;


        // Print a message after the wait
        Debug.Log("Waited for 1 seconds!");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerVortex")
        {

            SceneManager.LoadScene("LoseScreen");

        }
    }




    }


