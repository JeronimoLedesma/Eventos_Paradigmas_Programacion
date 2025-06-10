using UnityEngine;

public class NPC : MonoBehaviour
{
    public delegate void DialogueEvent();
    public static DialogueEvent Dialogue;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Talk();
        }
    }
    public void Talk()
    {
        Dialogue?.Invoke();
    }
}
