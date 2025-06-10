using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogue;
    void Speaking()
    {
        dialogue.enabled = true;
        dialogue.text = "Buen dia";
    }

    private void OnEnable()
    {
        NPC.Dialogue += Speaking;
    }

    private void OnDisable()
    {
        NPC.Dialogue -= Speaking;
    }
}
