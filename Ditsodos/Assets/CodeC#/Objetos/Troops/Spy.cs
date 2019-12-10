using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spy : Troop
{
    public override int attack()
    {
        throw new System.NotImplementedException();
    }

    public override int giveGoldToCastle()
    {
        throw new System.NotImplementedException();
    }

    public int stealGold()
    {
        return 0;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
