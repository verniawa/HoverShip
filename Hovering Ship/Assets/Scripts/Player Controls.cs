// GENERATED AUTOMATICALLY FROM 'Assets/Player Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""e35bf239-5d25-4966-9ccd-d8cc5e84eebf"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""33a7ca6f-4c7a-4804-b935-38787d0ce204"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""b68f151b-f84e-43cd-8123-1ced559d7dbe"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""dcf874af-6183-46d2-b65c-415d799462c5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""ceb994d2-2fb5-4ebd-9757-e139d096ffc0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AirBrake Left"",
                    ""type"": ""Button"",
                    ""id"": ""86b1a50a-4285-4129-8e91-509d1af2ffb9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AirBrake Right"",
                    ""type"": ""Button"",
                    ""id"": ""2c53f0bf-845b-4aab-b9ae-d93203b188f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""be70534d-687e-4de0-b330-fe69f76a4b05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""796a491a-f07c-4794-91d0-7ef8cbe76ef3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8581f2ea-35a5-4cb5-8db1-df59fa56952b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45b91478-6365-4c93-b541-acea58b54560"",
                    ""path"": ""<HID::Gravis Destroyer Tiltpad>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9df1fae2-d234-4bc8-9ceb-a329ef704833"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21fc91a4-c969-4857-b6ba-83c9f31389c1"",
                    ""path"": ""<Gamepad>/dpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left/Right"",
                    ""id"": ""ad646d1d-81f3-403e-8c3d-a57209d6705b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a3a29927-af41-4951-ac6c-4b1decd30bc0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5df0e0eb-9312-477f-b02d-9d1880714744"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3e4e2c74-ed4c-4867-884f-cedd4c8d7d1a"",
                    ""path"": ""<Joystick>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab301db8-d2ae-4e23-b7c1-55776b9d64ee"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b309d69-cb78-4076-9ae7-f7eac922bb40"",
                    ""path"": ""<Gamepad>/dpad/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up/Down"",
                    ""id"": ""9ee1bb0a-5469-48d8-87be-082937f55116"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""995b4498-6087-4e9d-8430-be9d8377f383"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d1932249-eb49-46c0-9c81-8dfca2bdab17"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a759ba9d-f6e5-4412-9ca8-8d5f0da77ead"",
                    ""path"": ""<Joystick>/stick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4cf071be-3438-4a9d-86e9-c3969944a276"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1558a12-92ff-47f5-b784-cc43b2c0b70c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acdf0c6d-d63f-4dc3-aea4-10c7e1ad22d4"",
                    ""path"": ""<HID::Gravis Destroyer Tiltpad>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28b4a653-8b4b-4b53-beb8-740e7e5459df"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""AirBrake Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cba2d98a-fd54-408e-821a-8c266a187ba8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AirBrake Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d229cfbe-908c-48ac-8b37-eb2c2b0cfc2e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirBrake Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f327bef5-00f5-4368-b695-cb9a96df4982"",
                    ""path"": ""<HID::Gravis Destroyer Tiltpad>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirBrake Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfb57505-e2ca-42ee-8504-e418a6270b5b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirBrake Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7aee4a0-8c0e-4bc7-9f82-dcd9ddd50e9c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirBrake Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af2baa30-874f-4164-b42d-405b02739234"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirBrake Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6d4e62d-946c-4333-be87-b51f77c1dfdc"",
                    ""path"": ""<HID::Gravis Destroyer Tiltpad>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirBrake Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32d01b89-05de-48fe-9f96-8883a26217e1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b66eae92-9d05-447f-9e32-ae7d8263727a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Accelerate = m_Gameplay.FindAction("Accelerate", throwIfNotFound: true);
        m_Gameplay_Steering = m_Gameplay.FindAction("Steering", throwIfNotFound: true);
        m_Gameplay_Pitch = m_Gameplay.FindAction("Pitch", throwIfNotFound: true);
        m_Gameplay_Reset = m_Gameplay.FindAction("Reset", throwIfNotFound: true);
        m_Gameplay_AirBrakeLeft = m_Gameplay.FindAction("AirBrake Left", throwIfNotFound: true);
        m_Gameplay_AirBrakeRight = m_Gameplay.FindAction("AirBrake Right", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Accelerate;
    private readonly InputAction m_Gameplay_Steering;
    private readonly InputAction m_Gameplay_Pitch;
    private readonly InputAction m_Gameplay_Reset;
    private readonly InputAction m_Gameplay_AirBrakeLeft;
    private readonly InputAction m_Gameplay_AirBrakeRight;
    private readonly InputAction m_Gameplay_Pause;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Gameplay_Accelerate;
        public InputAction @Steering => m_Wrapper.m_Gameplay_Steering;
        public InputAction @Pitch => m_Wrapper.m_Gameplay_Pitch;
        public InputAction @Reset => m_Wrapper.m_Gameplay_Reset;
        public InputAction @AirBrakeLeft => m_Wrapper.m_Gameplay_AirBrakeLeft;
        public InputAction @AirBrakeRight => m_Wrapper.m_Gameplay_AirBrakeRight;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAccelerate;
                @Steering.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSteering;
                @Pitch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPitch;
                @Reset.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReset;
                @AirBrakeLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirBrakeLeft;
                @AirBrakeLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirBrakeLeft;
                @AirBrakeLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirBrakeLeft;
                @AirBrakeRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirBrakeRight;
                @AirBrakeRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirBrakeRight;
                @AirBrakeRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirBrakeRight;
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @AirBrakeLeft.started += instance.OnAirBrakeLeft;
                @AirBrakeLeft.performed += instance.OnAirBrakeLeft;
                @AirBrakeLeft.canceled += instance.OnAirBrakeLeft;
                @AirBrakeRight.started += instance.OnAirBrakeRight;
                @AirBrakeRight.performed += instance.OnAirBrakeRight;
                @AirBrakeRight.canceled += instance.OnAirBrakeRight;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnSteering(InputAction.CallbackContext context);
        void OnPitch(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnAirBrakeLeft(InputAction.CallbackContext context);
        void OnAirBrakeRight(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
