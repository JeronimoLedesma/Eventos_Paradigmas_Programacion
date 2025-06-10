using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public bool paused;
    public Canvas canvas;

    void ToPause()
    {
        
        if (paused)
        {
            paused = false;
            canvas.enabled = true;
        }
        else
        {
            paused = true;
            canvas.enabled = false;
        }
    }

    private void OnEnable()
    {
        GameManager.pause += ToPause;
    }

    private void OnDisable()
    {
        GameManager.pause -= ToPause;
    }
}
