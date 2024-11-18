using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 4.0f;  //how fast player moves
    [SerializeField] private float gravityValue = -9.81f;   //player's gravity handle

    private CharacterController controller;
    private Vector3 playerVelocity;
    private InputManager inputManager;
    private Transform cameraTransform;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();//Get controller
        inputManager = InputManager.Instance;//Get input manager
        cameraTransform = Camera.main.transform;//Get camera
    }

    private void Update()
    {
        //player moves
        Vector2 movement = inputManager.GetPlayerMovement();
        Vector3 move = new Vector3(movement.x, 0f, movement.y);
        move = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        move.y = 0f;

        controller.Move(move * Time.deltaTime * playerSpeed);

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
