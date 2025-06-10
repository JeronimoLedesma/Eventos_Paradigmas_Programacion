using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void PauseEvent();
    public static event PauseEvent pause;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            pause?.Invoke();
        }
    }
}
