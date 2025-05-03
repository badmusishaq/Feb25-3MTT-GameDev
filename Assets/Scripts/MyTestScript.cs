using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyTestScript : MonoBehaviour
{
    int myNumber = 7;           // Default value is 0
    private float myValue;          // Default value is 0
    int numberOfSeats;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 5;
        //MoveVehicle();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space bar is pressed");
        }
        //Debug.Log("game is updating...");
        //transform.Rotate(transform.up * speed * Input.GetAxis("Horizontal"));
        transform.Rotate(transform.up * speed * Input.GetAxis("Mouse X"));
    }

    void EnterVehicle()
    {
        numberOfSeats = 5;
    }

    void MoveVehicle()
    {
        speed = 1;
        Debug.Log("Vehicle speed = " + speed);
    }

    public void GotoScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
