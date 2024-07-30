using UnityEngine;
using System.Collections;
using System;

namespace RPG.Attributes
{
    public class PotionHealth : MonoBehaviour
    {
        Health health;

        private void Start()
        {
            health = GameObject.FindWithTag("Player").GetComponent<Health>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Heal();
            }
        }

        public void Heal()
        {
            health.RegenerateHealth();
            Destroy(gameObject);
        }
    }
}