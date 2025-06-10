using TMPro;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public TextMeshProUGUI lifeText;
    private float health = 100;
    
    void HealthText(float damage)
    {
        health -= damage;
        lifeText.text = "VIDA: " + health;
    }

    private void OnEnable()
    {
        Player.healthEvent += HealthText;
    }

    private void OnDisable()
    {
        Player.healthEvent -= HealthText;
    }
}
