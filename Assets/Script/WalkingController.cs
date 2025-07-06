using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TeleportationProvider teleportationProvider;
    public ContinuousMoveProviderBase continuousMoveProvider;
    public TMP_Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    // Update is called once per frame
    private void OnDropdownValueChanged(int value)
    {
        string selectedOption = dropdown.options[value].text;
        if (selectedOption == "Continue Move")
        {
            Debug.Log("Continue Move selected");
            ContinueMove();
        }
        else if (selectedOption == "Teleport")
        {
            Debug.Log("Teleport selected");
            Teleport();
        }
    }

    void ContinueMove()
    {
        if (continuousMoveProvider.enabled)
        {
            Debug.Log("continuous Move Provider activated");
        }
        else
        {
            continuousMoveProvider.enabled = true;
        }
        teleportationProvider.enabled = false;
    }

    void Teleport()
    {
        if (teleportationProvider.enabled) {
            Debug.Log("Teleportation Provider activated");
        } else
        {
            teleportationProvider.enabled = true;
        }
        continuousMoveProvider.enabled = false;
    }

    void OnDestroy()
    {
        // Remove the listener when the object is destroyed
        dropdown.onValueChanged.RemoveListener(OnDropdownValueChanged);
    }
}
