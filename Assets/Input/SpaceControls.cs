// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/SpaceControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SpaceControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SpaceControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SpaceControls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""adea4557-002d-40d9-b5d2-b45fa18f26c9"",
            ""actions"": [
                {
                    ""name"": ""Appear"",
                    ""type"": ""Button"",
                    ""id"": ""e8a99999-bad1-47be-9485-4aee1bc641f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""70d1ceb5-e1ba-495c-a0d6-de8702350135"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Appear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Appear = m_Main.FindAction("Appear", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Appear;
    public struct MainActions
    {
        private @SpaceControls m_Wrapper;
        public MainActions(@SpaceControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Appear => m_Wrapper.m_Main_Appear;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Appear.started -= m_Wrapper.m_MainActionsCallbackInterface.OnAppear;
                @Appear.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnAppear;
                @Appear.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnAppear;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Appear.started += instance.OnAppear;
                @Appear.performed += instance.OnAppear;
                @Appear.canceled += instance.OnAppear;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnAppear(InputAction.CallbackContext context);
    }
}
