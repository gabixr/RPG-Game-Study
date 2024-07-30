using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RPG.Stats
{
    public class LevelDisplay : MonoBehaviour
    {
        BaseStats baseStats;

        private void Awake()
        {
            baseStats = GameObject.FindWithTag("Player").GetComponent<BaseStats>();
        }

        private void Update()
        {
            float level = baseStats.GetLevel();

            GetComponent<TextMeshProUGUI>().text = level.ToString();
        }
    }
}