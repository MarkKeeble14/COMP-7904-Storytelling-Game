//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/External/InputSystem/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4050ecf2-69ff-4c53-8e3e-3b77f6d1e065"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""71bd1572-0a55-43e7-b53d-8695e711446e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""d89d6992-7519-4098-ac6f-a8c268d4e6f5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""dce14a71-d9e8-4816-bcbd-93a9af7d45b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FireAttachment"",
                    ""type"": ""Button"",
                    ""id"": ""21cae116-6f47-4031-8447-71b866717b1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""59dbbbde-ac4d-49b7-8153-afd9b7054874"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""a55cbfa7-d4b9-4b54-8777-d330965c4a12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""bce3f1dc-3bd7-4684-95a5-0ea89cf2f7b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotkey1"",
                    ""type"": ""Button"",
                    ""id"": ""85699789-425c-4ff7-bf5e-8c916877400a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotkey2"",
                    ""type"": ""Button"",
                    ""id"": ""f5db8ba9-6902-4282-955d-867994008bea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotkey3"",
                    ""type"": ""Button"",
                    ""id"": ""8d415a8d-c04b-4708-af7d-2a1eefc18823"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""e5242b96-79b3-4393-8b08-8740883ed3eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""b3edd2a5-e395-43fd-8020-bab95016b6d8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Tab"",
                    ""type"": ""Button"",
                    ""id"": ""452774a1-eda2-433a-8392-1bbe72484d22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""286b19ff-707f-44aa-a9a8-6ffd6b1f6b05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""9ef44f56-0df4-4569-965b-eb5c8dcb8de7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""863ea43e-8b5a-48c1-89a8-90dca7ef1855"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ed782cc8-d087-4b6a-b483-a4211937defc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e26b906c-1786-411b-827f-8597072da6e6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c427ace3-1075-4d78-8462-a4e5cbc3bfda"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamePad"",
                    ""id"": ""adf765aa-596e-4a83-b6af-cf95049bf0ca"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e658022c-d5be-4268-bbfb-7d110c36437f"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a1ef10e2-013b-4bf4-8b6a-e464d0f44cef"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""91cb44f2-7f3b-4602-87c9-1cf031c76cd2"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f5f0801b-f080-4ce6-ae82-c9b5fc7571e9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""440adf3b-8bef-495d-b086-35cbde4682d9"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0089917c-aa29-456d-bdcc-db7c07d30c4f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91fafb62-d807-4c95-a8fc-b338c231a8e1"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40c739c9-4646-489c-a54d-7bf53347b088"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireAttachment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""444b20ba-904c-43ea-a544-ba13307501c6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84944bf0-cf13-417c-8983-2fc2f2ea019e"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea311aa6-1f7f-46f4-b698-817e2a1a747d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99a60abe-5783-4e40-a7c7-a25849efcfc1"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hotkey1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b62498bd-87dc-4b9d-b462-4cb143cefef2"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hotkey2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f723fae6-3de0-4218-95e6-1e8a5edb3f42"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hotkey3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""535de6a6-0be3-4099-9f4e-e4c83440ee8f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2b03908-bccc-471a-8162-c32692044bdb"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03a7b272-c7fe-4508-8f08-3a032dd5e08e"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9f0ef36-7bd0-43ea-a91f-657a83311fd4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
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
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_FireAttachment = m_Player.FindAction("FireAttachment", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Melee = m_Player.FindAction("Melee", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Hotkey1 = m_Player.FindAction("Hotkey1", throwIfNotFound: true);
        m_Player_Hotkey2 = m_Player.FindAction("Hotkey2", throwIfNotFound: true);
        m_Player_Hotkey3 = m_Player.FindAction("Hotkey3", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_MousePosition = m_Player.FindAction("MousePosition", throwIfNotFound: true);
        m_Player_Tab = m_Player.FindAction("Tab", throwIfNotFound: true);
        m_Player_Escape = m_Player.FindAction("Escape", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_FireAttachment;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Melee;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Hotkey1;
    private readonly InputAction m_Player_Hotkey2;
    private readonly InputAction m_Player_Hotkey3;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_MousePosition;
    private readonly InputAction m_Player_Tab;
    private readonly InputAction m_Player_Escape;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @FireAttachment => m_Wrapper.m_Player_FireAttachment;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Melee => m_Wrapper.m_Player_Melee;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Hotkey1 => m_Wrapper.m_Player_Hotkey1;
        public InputAction @Hotkey2 => m_Wrapper.m_Player_Hotkey2;
        public InputAction @Hotkey3 => m_Wrapper.m_Player_Hotkey3;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @MousePosition => m_Wrapper.m_Player_MousePosition;
        public InputAction @Tab => m_Wrapper.m_Player_Tab;
        public InputAction @Escape => m_Wrapper.m_Player_Escape;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @FireAttachment.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireAttachment;
                @FireAttachment.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireAttachment;
                @FireAttachment.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireAttachment;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Melee.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Hotkey1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHotkey1;
                @Hotkey1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHotkey1;
                @Hotkey1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHotkey1;
                @Hotkey2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHotkey2;
                @Hotkey2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHotkey2;
                @Hotkey2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHotkey2;
                @Hotkey3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHotkey3;
                @Hotkey3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHotkey3;
                @Hotkey3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHotkey3;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @MousePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @Tab.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTab;
                @Tab.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTab;
                @Tab.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTab;
                @Escape.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @FireAttachment.started += instance.OnFireAttachment;
                @FireAttachment.performed += instance.OnFireAttachment;
                @FireAttachment.canceled += instance.OnFireAttachment;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Hotkey1.started += instance.OnHotkey1;
                @Hotkey1.performed += instance.OnHotkey1;
                @Hotkey1.canceled += instance.OnHotkey1;
                @Hotkey2.started += instance.OnHotkey2;
                @Hotkey2.performed += instance.OnHotkey2;
                @Hotkey2.canceled += instance.OnHotkey2;
                @Hotkey3.started += instance.OnHotkey3;
                @Hotkey3.performed += instance.OnHotkey3;
                @Hotkey3.canceled += instance.OnHotkey3;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @Tab.started += instance.OnTab;
                @Tab.performed += instance.OnTab;
                @Tab.canceled += instance.OnTab;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnFireAttachment(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnHotkey1(InputAction.CallbackContext context);
        void OnHotkey2(InputAction.CallbackContext context);
        void OnHotkey3(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnTab(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
}
