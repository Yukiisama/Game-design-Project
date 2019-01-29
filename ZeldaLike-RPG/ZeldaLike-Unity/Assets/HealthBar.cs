using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    private GameObject m_player = null;
    private float maxHealth;
    Image healthBar = null;

    // Start is called before the first frame update
    void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
        maxHealth = m_player.GetComponent<PlayerBehavior>().maxHealth;
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = m_player.GetComponent<PlayerBehavior>().health / maxHealth;
    }
}
