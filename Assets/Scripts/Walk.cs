using UnityEngine;


public class Walk : MonoBehaviour
{
    public float moveSpeed = 5f;

    private CharacterController controller;
    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        moveDirection = new Vector3(moveX, 0, moveZ);

        if (moveDirection != Vector3.zero)
        {
            transform.forward = moveDirection;
        }

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}
