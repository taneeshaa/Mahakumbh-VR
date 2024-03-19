using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManipulation : MonoBehaviour
{
    public GameObject objectToMove;
    private bool isObjectSelected = false;
    private Vector3 offset;

    [SerializeField]
    private float rotateSpeed = 50f;
    [SerializeField]
    private float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 500f, Color.yellow, 10f);
            if (Physics.Raycast(ray, out hit, 500f))
            {
                objectToMove = hit.collider.gameObject;
                if (objectToMove == gameObject)
                {
                    isObjectSelected = true;
                    offset = transform.position - hit.point;
                }
                else
                {
                    isObjectSelected = false;
                }
            }
        }

        if (isObjectSelected)
        {
            // Rotation around Y-axis
            float rotationY = Input.GetKey(KeyCode.E) ? rotateSpeed * Time.deltaTime : Input.GetKey(KeyCode.Q) ? -rotateSpeed * Time.deltaTime : 0f;
            transform.Rotate(Vector3.up, rotationY, Space.World);

            // Movement along Z-axis
            float moveForward = Input.GetKey(KeyCode.X) ? moveSpeed * Time.deltaTime : Input.GetKey(KeyCode.Z) ? -moveSpeed * Time.deltaTime : 0f;

            // Movement up and down
            float moveUp = Input.GetKey(KeyCode.W) ? moveSpeed * Time.deltaTime : Input.GetKey(KeyCode.S) ? -moveSpeed * Time.deltaTime : 0f;
            // Movement left and right
            float moveLeft = Input.GetKey(KeyCode.D) ? moveSpeed * Time.deltaTime : Input.GetKey(KeyCode.A) ? -moveSpeed * Time.deltaTime : 0f;

            Vector3 movement = new Vector3(moveLeft, moveUp, moveForward);
            transform.Translate(movement, Space.Self);
        }
    }
}