using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputActions inputactions;

    [SerializeField] float andar;
    [SerializeField] float rotate;
    [SerializeField] float strafe;
    [SerializeField] float strafeL;
    [SerializeField] float strafeR;
    [SerializeField] CharacterController cc;

    bool running = false;


    Animator aController;

    //Vector de desplazamiento
    Vector3 moveVector;
    float speedMove;
    float speedStrafe;
    private void Awake()
    {
        inputactions = new InputActions();

        inputactions.Player.andar.performed += ctx => andar = ctx.ReadValue<float>();
        inputactions.Player.andar.canceled += _ => andar = 0f;

        inputactions.Player.rotar.performed += ctx => rotate = ctx.ReadValue<float>();
        inputactions.Player.rotar.canceled += _ => rotate = 0f;

        inputactions.Player.strafeL.performed += ctx => strafeL = ctx.ReadValue<float>();
        inputactions.Player.strafeL.canceled += _ => strafeL = 0f;

        inputactions.Player.strafeR.performed += ctx => strafeR = ctx.ReadValue<float>();
        inputactions.Player.strafeR.canceled += _ => strafeR = 0f;

        inputactions.Player.correr.started += _ => { corriendo = true; };
        inputactions.Player.correr.canceled += _ => { corriendo = false; };
    }

    // Start is called before the first frame update
    void Start()
    {
        aController = GetComponent<Animator>();
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

        if (running)
        {
            speedMove = 3f;
        }
        else if (andar < 0)
        {
            speedMove = 0.75f;
        }
        else
        {
            speedMove = 1.5f;
        };

        //Vector final
        moveVector = transform.right * strafe * speedStrafe;
        moveVector += transform.forward * andar * speedMove;

        //Mover al personaje
        cc.SimpleMove(moveVector);
        transform.Rotate(rotate * transform.up * 90 * Time.deltaTime);
    }

    void Animar()
    {
        aController.SetFloat("strafe", strafe);
        aController.SetFloat("andar", andar);
        aController.SetBool("correr", corriendo);
    }

    private void OnEnable()
    {
        inputactions.Enable();
    }
    private void OnDisable()
    {
        inputactions.Disable();
    }
}
