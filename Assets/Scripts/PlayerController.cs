using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject floor;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        InputManagement();
    }

    void InputManagement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if(floor.transform.rotation.z <= 0.25)
            {
                floor.transform.Rotate(Vector3.forward, 50 * Time.deltaTime, Space.World);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (floor.transform.rotation.z >= -0.25)
            {
                floor.transform.Rotate(Vector3.back, 50 * Time.deltaTime, Space.World);
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (floor.transform.rotation.x <= 0.25)
            {
                floor.transform.Rotate(Vector3.right, 50 * Time.deltaTime, Space.World);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (floor.transform.rotation.x >= -0.25)
            {
                floor.transform.Rotate(Vector3.left, 50 * Time.deltaTime, Space.World);
            }
        }
    }
}
