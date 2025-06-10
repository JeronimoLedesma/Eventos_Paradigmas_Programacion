using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int level;
    public TextMeshProUGUI levelText;

    void AdvanceLevel()
    {
        level++;
        levelText.text = "LEVEL: " + level;
    }

    private void OnEnable()
    {
        Level.levelChange += AdvanceLevel;
    }

    private void OnDisable()
    {
        Level.levelChange -= AdvanceLevel;
    }
}
