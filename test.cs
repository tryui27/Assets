using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class Boss

{
    private int hp = 100;
    private int power = 25;

    public void Attack()
    {
         Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damege)
    {
        Debug.Log(damege + "のダメージを受けた");

        this.hp = damege;
    }
}


   
    

public class test:MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();

        lastboss.Defence(3);

    }


    




    








// Update is called once per frame
void Update()
    {
        
    }
}
