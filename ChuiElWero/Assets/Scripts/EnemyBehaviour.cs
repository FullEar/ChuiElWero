using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float HitPoints;
    public float MaxHitPoints = 5;
    public HealthBarBehaviour HealthBar;


    // Start is called before the first frame update
    void Start()
    {
        HitPoints = MaxHitPoints;
        HealthBar.SetHealth(HitPoints, MaxHitPoints);
    }

    public void Takehit(float damage)
    {
        HitPoints -= damage;
        HealthBar.SetHealth(HitPoints, MaxHitPoints);

        if (HitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
