using Cinemachine;
using UnityEngine;

public class CinemachinePOVExtension : CinemachineExtension
{ 
    private Vector3 startingRotation;
    private InputManager inputManager;

    [SerializeField] private float lookSpeed = 10f; //camera move speed
    [SerializeField] private float clampAngle = 75f; //camera vertical rotation limits, we don't want the camera rotate 360 degrees vertically

    protected override void Awake()
    {
        inputManager = InputManager.Instance;
        base.Awake();
    }

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (vcam.Follow)
        {
            if (stage == CinemachineCore.Stage.Aim)
            {
                //player look
                if (startingRotation == null)   startingRotation = transform.localRotation.eulerAngles;

                Vector2 deltaInput = inputManager.GetMouseDelta();

                startingRotation.x += deltaInput.x * lookSpeed * Time.deltaTime;
                startingRotation.y += deltaInput.y * lookSpeed * Time.deltaTime;

                startingRotation.y = Mathf.Clamp(startingRotation.y, -clampAngle, clampAngle);
                state.RawOrientation = Quaternion.Euler(-startingRotation.y, startingRotation.x, 0f);
            }
        }
    }

}
