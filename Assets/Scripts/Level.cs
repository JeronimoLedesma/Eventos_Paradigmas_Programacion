using UnityEngine;

public class Level : MonoBehaviour
{
    public delegate void LevelEvent();
    public static LevelEvent levelChange;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            levelChange?.Invoke();
        }
    }
}
