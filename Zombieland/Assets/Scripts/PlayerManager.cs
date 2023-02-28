using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    InputActions inputActions;

    [SerializeField] float move;
    [SerializeField] float rotate;
    [SerializeField] float strafe;
    [SerializeField] float strafeL;
    [SerializeField] float strafeR;

    [SerializeField] CharacterController cc;
    Animator animator;

    bool corriendo = false;

    float speedMove = 1f;
    float speedStrafe = 1f;

    Vector3 moveVector;

    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.Player.andar.performed += ctx => move = ctx.ReadValue<float>();
        inputActions.Player.andar.canceled += ctx => move = 0f;

        inputActions.Player.rotar.performed += ctx => rotate = ctx.ReadValue<float>();
        inputActions.Player.rotar.canceled += ctx => rotate = 0f;


        inputActions.Player.strafeL.performed += ctx => strafeL = ctx.ReadValue<float>();
        inputActions.Player.strafeL.canceled += ctx => strafeL = 0f;

        inputActions.Player.strafeR.performed += ctx => strafeR = ctx.ReadValue<float>();
        inputActions.Player.strafeR.canceled += ctx => strafeR = 0f;


        inputActions.Player.correr.started += _ => corriendo = true;
        inputActions.Player.correr.canceled += _ => corriendo = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        Animar();
    }

    void Moving()
    {
        //Cálculo del strafe
        strafe = strafeR - strafeL;

        if (corriendo)
        {
            speedMove = 5f;
        }
        else if (move < 0)
        {
            speedMove = 3f;
        }
        else
        {
            speedMove = 3f;
        }

        moveVector = transform.right * strafe * speedStrafe;
        moveVector += transform.forward * move * speedMove;

        cc.SimpleMove(moveVector);

        transform.Rotate(rotate * transform.up * 135 * Time.deltaTime);
    }

    void Animar()
    {
        animator.SetFloat("strafe", strafe);
        animator.SetFloat("walk", move);

        if (corriendo)
        {
            animator.SetFloat("walk", move * 2);
        }
        else
        {
            animator.SetFloat("walk", move);
        }

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