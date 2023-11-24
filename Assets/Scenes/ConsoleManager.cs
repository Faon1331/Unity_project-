using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleManager : MonoBehaviour
{
    private bool isConsoleOpen = false;
    private bool isNoclipEnabled = false;
    private Rigidbody playerRigidbody;

    public GameObject consolePanel;
    public InputField consoleInputField;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        consolePanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleConsole();
        }

        if (isConsoleOpen && Input.GetKeyDown(KeyCode.Return))
        {
            string inputText = consoleInputField.text.ToLower();

            if (inputText == "noclip on")
            {
                EnableNoclip();
            }
            else if (inputText == "noclip off")
            {
                DisableNoclip();
            }

            consoleInputField.text = "";
            consolePanel.SetActive(false);
        }

        // Движение в режиме "noclip"
        if (isNoclipEnabled)
        {
            float moveSpeed = 10f;
            float verticalSpeed = 10f;
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;
            Vector3 moveVelocity = moveDirection * moveSpeed;

            // Учет вертикального движения
            moveVelocity.y += (Input.GetKey(KeyCode.Space) ? 1f : 0f) * verticalSpeed;
            moveVelocity.y -= (Input.GetKey(KeyCode.LeftControl) ? 1f : 0f) * verticalSpeed;

            // Применение скорости к Rigidbody
            playerRigidbody.velocity = moveVelocity;
        }
    }

    void ToggleConsole()
    {
        isConsoleOpen = !isConsoleOpen;
        consolePanel.SetActive(isConsoleOpen);

        if (isConsoleOpen)
        {
            consoleInputField.Select();
            consoleInputField.ActivateInputField();
        }

        Cursor.lockState = isConsoleOpen ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = isConsoleOpen;
    }

    void EnableNoclip()
    {
        isNoclipEnabled = true;
        playerRigidbody.velocity = Vector3.zero; // Сбрасываем скорость при включении noclip
        Debug.Log("Noclip enabled!");
    }

    void DisableNoclip()
    {
        isNoclipEnabled = false;
        Debug.Log("Noclip disabled!");
    }
}