using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{

    public int price;
    public int rentability;
    public int population_happiness;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameManager.money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
