using UnityEngine;
using TMPro;

public class ItemPickup : MonoBehaviour
{
    public string text;
    public TextMeshProUGUI texto;
    public Stats statsToAdd;
    public Stats minToAdd;
    public Stats maxToAdd;
    public GameObject hud;
    public GameObject pedestal;

    private void Start()
    {
        statsToAdd.maxHealth = Random.Range(minToAdd.maxHealth, maxToAdd.maxHealth);
        statsToAdd.attackPower = Random.Range(minToAdd.attackPower, maxToAdd.attackPower);
        statsToAdd.moveSpeed = Random.Range(minToAdd.moveSpeed, maxToAdd.moveSpeed);
        statsToAdd.attackSpeed = Random.Range(minToAdd.attackSpeed, maxToAdd.attackSpeed);
        statsToAdd.AttackTime = Random.Range(minToAdd.AttackTime, maxToAdd.AttackTime);

        Mejoras();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CharacterStats stats = other.GetComponent<CharacterStats>();
            if (stats != null)
            {
                hud.active = true;
            }
        }
        
    }


    public void ApplyStast()
    {
        
        CharacterStats stats = FindObjectOfType<CharacterStats>();
        if (stats != null)
        {
            stats.AddStats(statsToAdd);
        }
    }

    public string Mejoras()
    {
        
        if(statsToAdd.maxHealth > 0)
        {
            if(statsToAdd.maxHealth == 1)
            {
                text += "un corazon";
            }
            if (statsToAdd.maxHealth == 2)
            {
                text += "dos corazon";
            }
        }
        if (statsToAdd.attackPower > 0)
        {
            text += statsToAdd.attackPower;
        }
        if (statsToAdd.moveSpeed > 0)
        {
            text += statsToAdd.moveSpeed + " y " + statsToAdd.AttackTime;
        }
        if (texto) { 
            texto.text = text;
        }
        return text;
    }
}
