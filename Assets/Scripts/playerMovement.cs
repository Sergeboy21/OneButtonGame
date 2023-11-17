using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private int desiredLane = 1; // 0 = left, 1 = middle, 2 = right

    private const float LANE_DISTANCE = 3.0f;

    public float speed;

    private CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(controller.enabled);


        //inputs
        if (Input.GetKeyDown(KeyCode.A))
            MoveLane(false);
        if (Input.GetKeyUp(KeyCode.D))
            MoveLane(true);

        //calculate where to go
        Vector3 targetPosition = transform.position.z * Vector3.forward;
        if (desiredLane == 0)
            targetPosition += Vector3.left * LANE_DISTANCE;
        else if (desiredLane == 2)
            targetPosition += Vector3.right * LANE_DISTANCE;

        //calculate movement Delta
        Vector3 moveVector = Vector3.zero;
        moveVector.x = (targetPosition - transform.position).normalized.x * speed;
        moveVector.y = -0.1f;
        moveVector.z = speed;

        //Move the player
        controller.Move(moveVector * Time.deltaTime);
    }   

    private void MoveLane(bool goingRight)
    {
        desiredLane += (goingRight) ? 1 : -1;
        desiredLane = Mathf.Clamp(desiredLane, 0, 2);
    }
}
