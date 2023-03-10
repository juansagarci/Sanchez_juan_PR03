// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f4fc917e-3b7b-4424-9420-a01954495cc6"",
            ""actions"": [
                {
                    ""name"": ""andar"",
                    ""type"": ""Value"",
                    ""id"": ""3ca7e18a-dd7d-4aa2-b1cd-a9774cc5ef14"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""strafeL"",
                    ""type"": ""Value"",
                    ""id"": ""9c595917-9a79-4611-9cdf-9b2854b0a1c5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rotar"",
                    ""type"": ""Value"",
                    ""id"": ""f6460b10-24d9-492e-8d94-39558542f417"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""correr"",
                    ""type"": ""Button"",
                    ""id"": ""4e7d39b2-08e0-418e-8811-914fadd1be3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""strafeR"",
                    ""type"": ""Value"",
                    ""id"": ""07cc308e-1169-4dfe-b789-b6054f83a925"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""apuntar"",
                    ""type"": ""Button"",
                    ""id"": ""c4d9806f-a251-4d60-a51d-88556a90d8fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""15fa91c7-c6c5-49e9-a21d-e44b50ab3efa"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""andar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea6b7dc2-184b-4269-aa3a-ffbe47d1344e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""strafeL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddd4246e-37e8-4be7-b6ea-b9f60dce80db"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f79f0804-2c37-4f6d-8ca1-fd4f8c569771"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bbcefae-6c77-452f-bd44-26c1f0d14719"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""strafeR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d303867f-c551-4a5f-8d42-8700d88972bc"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""92a64fd8-964c-45e7-8a53-c00643ab4b7d"",
            ""actions"": [
                {
                    ""name"": ""apuntando"",
                    ""type"": ""Button"",
                    ""id"": ""4a2cf1a8-b618-408f-9606-9ae15e5bc062"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pivotar"",
                    ""type"": ""Value"",
                    ""id"": ""7069c1cb-1b7c-4fbd-ba61-f45809b343af"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bdfdaac9-1216-4e7e-afbc-7d1dbb23aeae"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""apuntando"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""768a25f4-0ee0-44e1-a7a2-281b8cee9ffc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pivotar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_andar = m_Player.FindAction("andar", throwIfNotFound: true);
        m_Player_strafeL = m_Player.FindAction("strafeL", throwIfNotFound: true);
        m_Player_rotar = m_Player.FindAction("rotar", throwIfNotFound: true);
        m_Player_correr = m_Player.FindAction("correr", throwIfNotFound: true);
        m_Player_strafeR = m_Player.FindAction("strafeR", throwIfNotFound: true);
        m_Player_apuntar = m_Player.FindAction("apuntar", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_apuntando = m_Camera.FindAction("apuntando", throwIfNotFound: true);
        m_Camera_pivotar = m_Camera.FindAction("pivotar", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_andar;
    private readonly InputAction m_Player_strafeL;
    private readonly InputAction m_Player_rotar;
    private readonly InputAction m_Player_correr;
    private readonly InputAction m_Player_strafeR;
    private readonly InputAction m_Player_apuntar;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @andar => m_Wrapper.m_Player_andar;
        public InputAction @strafeL => m_Wrapper.m_Player_strafeL;
        public InputAction @rotar => m_Wrapper.m_Player_rotar;
        public InputAction @correr => m_Wrapper.m_Player_correr;
        public InputAction @strafeR => m_Wrapper.m_Player_strafeR;
        public InputAction @apuntar => m_Wrapper.m_Player_apuntar;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @andar.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAndar;
                @andar.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAndar;
                @andar.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAndar;
                @strafeL.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrafeL;
                @strafeL.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrafeL;
                @strafeL.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrafeL;
                @rotar.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotar;
                @rotar.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotar;
                @rotar.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotar;
                @correr.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @correr.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @correr.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @strafeR.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrafeR;
                @strafeR.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrafeR;
                @strafeR.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrafeR;
                @apuntar.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnApuntar;
                @apuntar.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnApuntar;
                @apuntar.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnApuntar;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @andar.started += instance.OnAndar;
                @andar.performed += instance.OnAndar;
                @andar.canceled += instance.OnAndar;
                @strafeL.started += instance.OnStrafeL;
                @strafeL.performed += instance.OnStrafeL;
                @strafeL.canceled += instance.OnStrafeL;
                @rotar.started += instance.OnRotar;
                @rotar.performed += instance.OnRotar;
                @rotar.canceled += instance.OnRotar;
                @correr.started += instance.OnCorrer;
                @correr.performed += instance.OnCorrer;
                @correr.canceled += instance.OnCorrer;
                @strafeR.started += instance.OnStrafeR;
                @strafeR.performed += instance.OnStrafeR;
                @strafeR.canceled += instance.OnStrafeR;
                @apuntar.started += instance.OnApuntar;
                @apuntar.performed += instance.OnApuntar;
                @apuntar.canceled += instance.OnApuntar;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_apuntando;
    private readonly InputAction m_Camera_pivotar;
    public struct CameraActions
    {
        private @InputActions m_Wrapper;
        public CameraActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @apuntando => m_Wrapper.m_Camera_apuntando;
        public InputAction @pivotar => m_Wrapper.m_Camera_pivotar;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @apuntando.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnApuntando;
                @apuntando.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnApuntando;
                @apuntando.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnApuntando;
                @pivotar.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnPivotar;
                @pivotar.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnPivotar;
                @pivotar.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnPivotar;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @apuntando.started += instance.OnApuntando;
                @apuntando.performed += instance.OnApuntando;
                @apuntando.canceled += instance.OnApuntando;
                @pivotar.started += instance.OnPivotar;
                @pivotar.performed += instance.OnPivotar;
                @pivotar.canceled += instance.OnPivotar;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IPlayerActions
    {
        void OnAndar(InputAction.CallbackContext context);
        void OnStrafeL(InputAction.CallbackContext context);
        void OnRotar(InputAction.CallbackContext context);
        void OnCorrer(InputAction.CallbackContext context);
        void OnStrafeR(InputAction.CallbackContext context);
        void OnApuntar(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnApuntando(InputAction.CallbackContext context);
        void OnPivotar(InputAction.CallbackContext context);
    }
}
