using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEntity : Entity {
    public Slider healthbBar;


    public override void ModifyHealth(int amount)
    {
        base.ModifyHealth(amount);
        healthbBar.value = health;
    }

   
}
