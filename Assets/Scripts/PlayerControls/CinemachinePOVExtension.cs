using Cinemachine;
using UnityEngine;

public class CinemachinePOVExtension : CinemachineExtension
{ 
    private Vector3 startingRotation;
    private InputManager inputManager;

    [SerializeField] private float lookSpeed = 10f;
    [SerializeField] private float clampAngle = 75f;

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
