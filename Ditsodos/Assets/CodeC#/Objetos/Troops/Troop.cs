using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Troop : MonoBehaviour
{

    private int price { get; set; }
    private int troopHp { get; set; }
    private int movement { get; set; }
    private int trooAttack { get; set; }
    private int range { get; set; }
    private int goldCarrying { get; set; }


    public abstract int attack();
    public abstract int giveGoldToCastle();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
