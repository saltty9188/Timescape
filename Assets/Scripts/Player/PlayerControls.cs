// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

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
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""71910e71-031b-406c-9303-e4e0ca65cfa8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""79c7f7dd-6c2d-4c09-a558-8bd62a109e3b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""41688b64-27c7-46ed-9a17-af4583e0dde9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AimStick"",
                    ""type"": ""Value"",
                    ""id"": ""8853bc05-6f28-417f-b1dd-49b53bb0c830"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AimMouse"",
                    ""type"": ""Value"",
                    ""id"": ""701949bf-b17d-43ed-8d25-2145bdfe0168"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""4b0b7f37-36a6-418d-bd6f-9714a0160fc7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Record"",
                    ""type"": ""Button"",
                    ""id"": ""75979c11-6f28-4130-83a8-62b4a5ce2349"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CyclePhysics"",
                    ""type"": ""Value"",
                    ""id"": ""6d7978aa-24f1-446c-9a91-24a3ba16253d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""9b026e19-a1b8-42b5-98a2-00604efd4578"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CycleObjects"",
                    ""type"": ""Value"",
                    ""id"": ""5a6cd57e-0af2-49fa-8652-49a392c2eec3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""87549b93-9c42-4f41-96a9-3145ae678ded"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""6408b7b7-4ab5-49c8-9e19-d81883c78ed5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""3c6776f4-ddd1-47f5-b487-ca17a08e013b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3762c1dd-f4de-409c-b790-2dd9d77f9188"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb563724-49d9-4b07-88d1-3b994ec177ff"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0da10cdf-1fe8-4601-9c41-c58dedf2a601"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""29a2e76b-67a5-436e-9955-667cc9f14894"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""60efab70-cdca-4ea9-a95d-c85c321dc8cd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""696376e9-6dad-4f25-b45e-37fc0fccccee"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb0f78cf-19d6-47cf-8844-00be18e737bc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""89fca25a-f926-45e2-975b-e66e62952835"",
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
                    ""id"": ""2d8c0fc2-af7f-4c91-be12-b8caa67b44c6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ef5581f5-90af-4d25-9ae7-bf143c03fa43"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4d303623-ea52-430c-b654-4ce1c2d65562"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f515f122-e204-44a6-9186-071d1dc1ee2d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b56bca98-d69c-4e80-9544-388b18ffbb90"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ba143e0-9f52-4422-8d95-e997cfbd9da3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76554bb6-e04e-4834-a48c-f239c26831ad"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.35)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AimStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76503deb-15e1-4a3c-b1de-4f80f678edf9"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""AimMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8afb0218-6abc-4c10-9561-c1bda73a36eb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e49de0a-d491-40c9-b2ff-d856d824ed50"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d962f7a-be10-4a23-8bf2-83aab711da89"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Record"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""342b0ebb-7c69-44da-b73e-403b1a88a6cd"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Record"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00137391-1ba4-41e3-a759-b4534e420237"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""CyclePhysics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""L1 and R1"",
                    ""id"": ""866f0d5d-c8ce-417e-b906-c89e0a746fe7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CyclePhysics"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ffe19e69-8eff-481a-91fb-15e348c91880"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CyclePhysics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""60dec2b0-7898-4d84-af55-c829c2ca1223"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CyclePhysics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""531fe2e6-4011-4797-ba14-ab419de05ecb"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CyclePhysics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""70044a80-313c-4287-b1c2-1a0f5f29a7f1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CyclePhysics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""88ba8e24-8d16-477a-8503-54240c527a6f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f3f8dd2-dac9-4e5b-bb95-86e2c2bcde7d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""L1R1"",
                    ""id"": ""f01b0962-6c4e-4642-b58f-1e5d0ff42b3d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CycleObjects"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1a829db1-0def-436e-b194-a83c4f18baf4"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CycleObjects"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""908f6689-31cb-43ed-a42a-633d5d007cec"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CycleObjects"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""QandE"",
                    ""id"": ""a22a8785-9e3b-4971-8048-52fe35b28830"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CycleObjects"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bf992572-8134-4080-86ea-1e0371bddba2"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""CycleObjects"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""741db074-3f1f-4054-8217-083ed0b5fbcd"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""CycleObjects"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fd28740a-3fcb-410c-b4a8-d67089f06cf9"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1871fb5d-47fd-4371-86d9-0b77cc324a32"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4071acd-21d9-41a0-af3a-1a172179791b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8003378c-9a2b-4e3a-8d8d-bbc79b67cf47"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad67d708-110e-4904-8f85-18b2dc761562"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcf86673-2c24-44c8-ab66-3013641746b2"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menus"",
            ""id"": ""26086be6-48c6-4249-a6c8-c0b0aaf6b329"",
            ""actions"": [
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""e7ff5270-4fd1-428e-b349-df227d1a0528"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Erase"",
                    ""type"": ""Button"",
                    ""id"": ""251caa6d-7200-4ed4-9abc-07e10f73fbcb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1af64f04-d4b4-493d-92f7-5207a0b47e4a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f113ae87-3eeb-40ec-8a8e-5425605a7dfa"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51531725-37d6-4cda-947b-a2cc7335a2b3"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2420bbd3-a851-45a8-85a4-00f7e4d3ab59"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Erase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53fece0f-26db-4194-a97d-9458df083d5b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Erase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_AimStick = m_Gameplay.FindAction("AimStick", throwIfNotFound: true);
        m_Gameplay_AimMouse = m_Gameplay.FindAction("AimMouse", throwIfNotFound: true);
        m_Gameplay_Shoot = m_Gameplay.FindAction("Shoot", throwIfNotFound: true);
        m_Gameplay_Record = m_Gameplay.FindAction("Record", throwIfNotFound: true);
        m_Gameplay_CyclePhysics = m_Gameplay.FindAction("CyclePhysics", throwIfNotFound: true);
        m_Gameplay_Interact = m_Gameplay.FindAction("Interact", throwIfNotFound: true);
        m_Gameplay_CycleObjects = m_Gameplay.FindAction("CycleObjects", throwIfNotFound: true);
        m_Gameplay_Cancel = m_Gameplay.FindAction("Cancel", throwIfNotFound: true);
        m_Gameplay_Grab = m_Gameplay.FindAction("Grab", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        // Menus
        m_Menus = asset.FindActionMap("Menus", throwIfNotFound: true);
        m_Menus_Back = m_Menus.FindAction("Back", throwIfNotFound: true);
        m_Menus_Erase = m_Menus.FindAction("Erase", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_AimStick;
    private readonly InputAction m_Gameplay_AimMouse;
    private readonly InputAction m_Gameplay_Shoot;
    private readonly InputAction m_Gameplay_Record;
    private readonly InputAction m_Gameplay_CyclePhysics;
    private readonly InputAction m_Gameplay_Interact;
    private readonly InputAction m_Gameplay_CycleObjects;
    private readonly InputAction m_Gameplay_Cancel;
    private readonly InputAction m_Gameplay_Grab;
    private readonly InputAction m_Gameplay_Pause;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @AimStick => m_Wrapper.m_Gameplay_AimStick;
        public InputAction @AimMouse => m_Wrapper.m_Gameplay_AimMouse;
        public InputAction @Shoot => m_Wrapper.m_Gameplay_Shoot;
        public InputAction @Record => m_Wrapper.m_Gameplay_Record;
        public InputAction @CyclePhysics => m_Wrapper.m_Gameplay_CyclePhysics;
        public InputAction @Interact => m_Wrapper.m_Gameplay_Interact;
        public InputAction @CycleObjects => m_Wrapper.m_Gameplay_CycleObjects;
        public InputAction @Cancel => m_Wrapper.m_Gameplay_Cancel;
        public InputAction @Grab => m_Wrapper.m_Gameplay_Grab;
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
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @AimStick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAimStick;
                @AimStick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAimStick;
                @AimStick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAimStick;
                @AimMouse.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAimMouse;
                @AimMouse.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAimMouse;
                @AimMouse.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAimMouse;
                @Shoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Record.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRecord;
                @Record.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRecord;
                @Record.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRecord;
                @CyclePhysics.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCyclePhysics;
                @CyclePhysics.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCyclePhysics;
                @CyclePhysics.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCyclePhysics;
                @Interact.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @CycleObjects.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCycleObjects;
                @CycleObjects.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCycleObjects;
                @CycleObjects.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCycleObjects;
                @Cancel.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCancel;
                @Grab.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrab;
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @AimStick.started += instance.OnAimStick;
                @AimStick.performed += instance.OnAimStick;
                @AimStick.canceled += instance.OnAimStick;
                @AimMouse.started += instance.OnAimMouse;
                @AimMouse.performed += instance.OnAimMouse;
                @AimMouse.canceled += instance.OnAimMouse;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Record.started += instance.OnRecord;
                @Record.performed += instance.OnRecord;
                @Record.canceled += instance.OnRecord;
                @CyclePhysics.started += instance.OnCyclePhysics;
                @CyclePhysics.performed += instance.OnCyclePhysics;
                @CyclePhysics.canceled += instance.OnCyclePhysics;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @CycleObjects.started += instance.OnCycleObjects;
                @CycleObjects.performed += instance.OnCycleObjects;
                @CycleObjects.canceled += instance.OnCycleObjects;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menus
    private readonly InputActionMap m_Menus;
    private IMenusActions m_MenusActionsCallbackInterface;
    private readonly InputAction m_Menus_Back;
    private readonly InputAction m_Menus_Erase;
    public struct MenusActions
    {
        private @PlayerControls m_Wrapper;
        public MenusActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Back => m_Wrapper.m_Menus_Back;
        public InputAction @Erase => m_Wrapper.m_Menus_Erase;
        public InputActionMap Get() { return m_Wrapper.m_Menus; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenusActions set) { return set.Get(); }
        public void SetCallbacks(IMenusActions instance)
        {
            if (m_Wrapper.m_MenusActionsCallbackInterface != null)
            {
                @Back.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnBack;
                @Erase.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnErase;
                @Erase.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnErase;
                @Erase.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnErase;
            }
            m_Wrapper.m_MenusActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @Erase.started += instance.OnErase;
                @Erase.performed += instance.OnErase;
                @Erase.canceled += instance.OnErase;
            }
        }
    }
    public MenusActions @Menus => new MenusActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAimStick(InputAction.CallbackContext context);
        void OnAimMouse(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnRecord(InputAction.CallbackContext context);
        void OnCyclePhysics(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnCycleObjects(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IMenusActions
    {
        void OnBack(InputAction.CallbackContext context);
        void OnErase(InputAction.CallbackContext context);
    }
}
