﻿using UnityEngine; using System.Collections;  public class Boss {     private int hp = 100;          // 体力     private int power = 25; // 攻撃力     private int mp = 53; //魔法力     // 攻撃用の関数     public void Attack() {         Debug.Log(this.power + "のダメージを与えた");     }     // 防御用の関数     public void Defence(int damage) {         Debug.Log(damage + "のダメージを受けた");         // 残りhpを減らす         this.hp -= damage;     }      //魔法力の関数     public void Magic()     {         if (mp >= 5)         {             Debug.Log("魔法攻撃をした。残りMPは" + mp);             // mpを5減らす             this.mp -= 5;         }         else         {             Debug.Log("MPが足りないため魔法が使えない。");         }     }  }     public class Test1 : MonoBehaviour {     void Start()     {         // Bossクラスの変数を宣言してインスタンスを代入         Boss lastboss = new Boss();         // 攻撃用の関数を呼び出す         lastboss.Attack();         // 防御用の関数を呼び出す         lastboss.Defence(3);          //10回処理を繰り返す         for (int mp = 0; mp < 10; mp++)         {             // 魔法用の関数を呼び出す             lastboss.Magic();         }         // 魔法用の関数を呼び出す         lastboss.Magic();     }     // Update is called once per frame     void Update()     {      } }