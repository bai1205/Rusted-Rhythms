using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
using Unity.VisualScripting;

public class HandMenuSetting : MonoBehaviour
{
    public GameObject settingButton;
    public GameObject button;
    public GameObject scrollBar;
    public ContinuousMoveProviderBase continuousMoveProvider;
    public TeleportationProvider teleportationProvider;
    public GameObject walkingSetting;
    public GameObject backArrow;
    public TMP_Dropdown dropdown;
    public LineRenderer lineRenderer;
    public XRInteractorLineVisual lineVisual;
    public XRRayInteractor rayInteractor;

    private bool isDropdownValueChanging = false;

    void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
        dropdown.value = 1;
        Log("Dropdown event listener added");
        OnDropdownValueChanged(dropdown.value); // 手动触发一次
    }

    void ToggleUI(bool isSettingMode)
    {
        button.SetActive(!isSettingMode);
        scrollBar.SetActive(!isSettingMode);
        settingButton.SetActive(!isSettingMode);
        backArrow.SetActive(isSettingMode);
        walkingSetting.SetActive(isSettingMode);
    }

    public void settingButtonClicked()
    {
        ToggleUI(true);
    }

    public void back()
    {
        ToggleUI(false);
    }

    private void OnDropdownValueChanged(int value)
    {
        Log($"Dropdown changed to value: {value}");
        Log($"Selected option: {dropdown.options[value].text}");

        switch (value)
        {
            case 0: // Teleport
                Teleport();
                break;
            case 1: // Continue Move
                ContinueMove();
                break;
            default:
                Log("Unknown dropdown value");
                break;
        }
    }

    private void ContinueMove()
    {
        Log("Attempting to enable Continuous Move...");
        if (!continuousMoveProvider.enabled)
        {
            continuousMoveProvider.enabled = true;
             Log("Continuous Move Provider activated");
        }
        teleportationProvider.enabled = false;
        if (teleportationProvider.enabled)
        {
            teleportationProvider.enabled = false;
            Log("Teleportation Provider deactivated");
        }
        DeactivateXRComponents();

        // 暂时禁用监听器以避免递归调用
        isDropdownValueChanging = true;
        dropdown.value = 1;
        isDropdownValueChanging = false;
        Log("Continuous Move setup complete.");
    }

    private void Teleport()
    {
        if (!teleportationProvider.enabled)
        {
            teleportationProvider.enabled = true;
            Debug.Log("Teleportation Provider activated");
        }
        continuousMoveProvider.enabled = false;
        ActivateXRComponents();
        // 暂时禁用监听器以避免递归调用
        isDropdownValueChanging = true;
        dropdown.value = 0;
        isDropdownValueChanging = false;
    }

    private void DeactivateXRComponents()
    {
        if (lineRenderer != null)
        {
            lineRenderer.enabled = false;
            Log("Line Renderer deactivated");
        }

        if (lineVisual != null)
        {
            lineVisual.enabled = false;
            Log("XR Interactor Line Visual deactivated");
        }

        if (rayInteractor != null)
        {
            rayInteractor.enabled = false;
            Log("XR Ray Interactor deactivated");
        }
    }

    private void ActivateXRComponents()
    {
        if (lineRenderer != null)
        {
            lineRenderer.enabled = true;
            Log("Line Renderer activated");
        }

        if (lineVisual != null)
        {
            lineVisual.enabled = true;
            Log("XR Interactor Line Visual activated");
        }

        if (rayInteractor != null)
        {
            rayInteractor.enabled = true;
            Log("XR Ray Interactor activated");
        }
    }

    void OnEnable()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    void OnDisable()
    {
        dropdown.onValueChanged.RemoveListener(OnDropdownValueChanged);
    }

    private void Log(string message)
    {
        Debug.Log($"[HandMenuSetting] {message}");
    }
}
