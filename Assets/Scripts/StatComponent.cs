using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class StatComponent : MonoBehaviour
    {
        private float currentHealth;
        private float currentMana;

        private float maxHealth;
        private float maxMana;

        public Image manaBar;

        public float MaxHealth { get; set; }
        public float CurrentHealth { get; set; }
        public float MaxMana { get; set; }
        public float CurrentMana { get; set; }

        public void Init()
        {
            currentHealth = MaxHealth;
            currentMana = MaxMana;
            UpdateStaminaBar(this.gameObject);
            UpdateHealthBar(this.gameObject);
        }

        public Mana GetStamina()
        {
            if (currentMana == 0)
            {
                return Mana.Zero;
            }
            else if (currentMana == maxMana)
            {
                return Mana.Full;
            }
            else
            {
                return Mana.NotZero;
            }
        }

        public void ConsumeStamina(float turn)
        {
            if (currentMana > 0)
            {
                currentMana -= turn;
            }

            UpdateStaminaBar(this.gameObject);
        }

        public void RecoverStamina(float turn)
        {
            if (currentMana >= 0)
            {
                currentMana += turn;
            }

            UpdateStaminaBar(this.gameObject);
        }

        private void UpdateStaminaBar(GameObject obj)
        {
            CurrentMana = currentMana;
            obj.GetComponent<Image>().fillAmount = ((float)currentMana);
        }

        public Health GetHealth()
        {
            if (currentHealth == 0)
            {
                return Health.Zero;
            }
            else if (currentHealth == maxHealth)
            {
                return Health.Full;
            }
            else
            {
                return Health.NotZero;
            }
        }

        public void ConsumeHealth(float dmg)
        {
            currentHealth -= dmg;

            UpdateHealthBar(this.gameObject);
        }

        public void RecoverHealth(float hp)
        {
            currentHealth += hp;

            UpdateHealthBar(this.gameObject);
        }

        private void UpdateHealthBar(GameObject obj)
        {
            CurrentHealth = currentHealth;
            obj.GetComponent<Image>().fillAmount = ((float)currentHealth);
        }
    }
}