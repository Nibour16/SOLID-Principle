using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;

    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private PlayerInput playerInput;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        playerInput = new PlayerInput(); //reference the player input system
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    public Vector2 GetPlayerMovement() //player action: movement (WASD, to move the player himself)
    {
        return playerInput.PlayerActions.Movement.ReadValue<Vector2>();
    }

    public Vector2 GetMouseDelta() //player action: look (Mouse movement, to rotate the player view (player camera))
    {
        return playerInput.PlayerActions.Look.ReadValue<Vector2>();
    }
}
