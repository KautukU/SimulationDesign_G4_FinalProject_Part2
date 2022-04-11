using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject floor;
    Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        point = new Vector3(-3, 0, -3);
    }

    // Update is called once per frame
    void Update()
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
