using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RPG.Attributes
{
    public class HealthDisplay : MonoBehaviour
    {
        Health health;

        private void Awake()
        {
            health = GameObject.FindWithTag("Player").GetComponent<Health>();
        }

        private void Update()
        {
           float health_points = health.GetHealthPoints();
           float max_health_points = health.GetMaxHealthPoints();

            string healthText = $"{health_points}:{max_health_points}";

            GetComponent<TextMeshProUGUI>().text = healthText;
        }
    }
}
