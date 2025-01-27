using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    [SerializeField] private float hp = 100f;
    [SerializeField] private float maxHp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateHp(float delta)
    {
        hp = Mathf.Clamp(hp + delta, 0, maxHp);
    }
}
