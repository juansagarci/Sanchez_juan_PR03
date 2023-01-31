using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    InputActions inputActions;
    [SerializeField] GameObject aimCamera;

    private void Awake()
    {
        inputActions = new InputActions();
        inputActions.Camera.apuntando.started += _ =>
        {
            aimCamera.SetActive(true);
        };

        inputActions = new InputActions();
        inputActions.Camera.apuntando.canceled += _ =>
        {
            aimCamera.SetActive(false);
        };
    }
    // Start is called before the first frame update
    void Start()
    {
        aimCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
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
