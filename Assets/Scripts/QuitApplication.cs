using UnityEngine;
using UnityEngine.InputSystem;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {
        if((Keyboard.current.altKey.isPressed & Keyboard.current.f4Key.isPressed) || Keyboard.current.escapeKey.isPressed)
        {
            Application.Quit();
            Debug.Log("Quit.");
        }
    }
}
