using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [Header("Horinztonal Input Axis")]
    [Tooltip("The Axis at which the Player moves horizontally (in this case A & D)")]
    [SerializeField] private string horizontalInputName;
    [Header("Vertical Input Axis")]
    [Tooltip("The Axis at which the Player moves vertically (in this case W & S)")]
    [SerializeField] private string verticalInputName;
    [Header("Movement Speed")]
    [Tooltip("The Speed at which the Player is moving on all Axis")]
    [SerializeField] private float mvS;

    [Header("Slope Data")]
    [SerializeField] private float slopeForce;
    [SerializeField] private float slopeForceRayLength;

    private CharacterController charController;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName);
        float vertInput = Input.GetAxis(verticalInputName);

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;


        charController.SimpleMove(Vector3.ClampMagnitude(forwardMovement + rightMovement, 1.0f) * mvS);

        if ((vertInput != 0 || horizInput != 0) && OnSlope())
            charController.Move(Vector3.down * charController.height / 2 * slopeForce * Time.deltaTime);
    }

    private bool OnSlope()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, charController.height / 2 * slopeForceRayLength))
            if (hit.normal != Vector3.up)
                return true;
        return false;
    }
}