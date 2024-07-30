using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RPG.Stats
{
    public class ExperienceDisplay : MonoBehaviour
    {
        Experiencee experience;

        private void Awake()
        {
            experience = GameObject.FindWithTag("Player").GetComponent<Experiencee>();
        }

        private void Update()
        {
            float experience_points = experience.GetPoints();

            GetComponent<TextMeshProUGUI>().text = experience_points.ToString();
        }
    }
}