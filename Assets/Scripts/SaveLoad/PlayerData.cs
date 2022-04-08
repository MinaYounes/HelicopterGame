using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int coins;
    public int sceneTracker;
    public int deadSceneTracker;
    public int level;
    public bool email;
    public int bullet1Damage;
    public float bullet1Speed;
    public int bullet2Damage;
    public float bullet2Speed;
    public int bullet3Damage;
    public float bullet3Speed;

    public PlayerData()
    {
        coins = CoinCount.coins;
        sceneTracker = LevelSuccessController.SceneTracker;
        deadSceneTracker = DeathController.SceneTracker;
        level = EnemyPlane.level;
        email = ReadInput.emailEntered;
        
        bullet1Damage = Bullet.damage;
        bullet1Speed = Bullet.speed;

        bullet2Damage = Bullet2.damage;
        bullet2Speed = Bullet2.speed;

        bullet3Damage = Bullet3.damage;
        bullet3Speed = Bullet3.speed;

    }

}
