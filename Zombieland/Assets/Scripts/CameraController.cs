using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject aimCamera;
    [SerializeField] InputActions inputActions;

    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.Camera.apuntando.started += ctx =>
        {
            aimCamera.SetActive(true);
        };
        inputActions.Camera.apuntando.canceled += ctx => aimCamera.SetActive(false);

        aimCamera.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}