using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Image healthGauge;
    public CharacterManager opponent;
    public float health = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        healthGauge.fillAmount = health;
    }

    public void State(float value)
    {
        health -= value;
        healthGauge.fillAmount = health / 100;
    }

    public void Damage(float damage)
    {
        State(damage);
    }

    public void Animation(string name)
    {
        opponent.GetComponent<Animator>().Play(name);
    }

    public void Opportunity(int count)
    {
        int rand = Random.Range(0, 2);

        if(count == rand)
        {
            gameObject.GetComponent<Animator>().SetTrigger("Attack");
        }
        else
        {
            opponent.GetComponent<Animator>().SetTrigger("Attack");
        }
    }
}
