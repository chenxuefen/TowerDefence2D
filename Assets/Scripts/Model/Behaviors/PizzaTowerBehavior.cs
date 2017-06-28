﻿using Com.TowerDefence2d;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizzaTowerBehavior : BaseTowerBehavior {

    protected override void fire() 
    {
        base.fire();

        if (target != null)
        {
            Vector2 currPos = new Vector2(this.gameObject.transform.position.x,
                this.gameObject.transform.position.y  + 0.5f);

            Vector2 tarPos = target.position;
//            Debug.Log(tarPos);
            GameObject cannonBall = CannonBallFactory.getInstance().generateCannonBall(currPos, tarPos, BallType.PizzaBall);
            cannonBall.GetComponent<PizzaBallBehavior>().target = target.gameObject;
            cannonBall.GetComponent<PizzaBallBehavior>().damage = damage;
        }

    }

}