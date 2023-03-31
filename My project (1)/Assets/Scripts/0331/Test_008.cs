using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;                                   //변수 hp를 private 하게 선언 100입력
    private int Power = 50;                                 //변수 Power를 private 하게 선언 50 입력

    public void Attack()                                    //메소드 Attack 생성
    {
        Debug.Log(this.Power + " 데미지를 입혔다.");

    }

    public void Damage(int damage)                          //메소드 damage 생성
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다.");
    }

    public int GetHp()
    {
        return hp;
    }

}
public class Test_008 : MonoBehaviour
{
    public Text playerHp;                                    //Player Hp 보여주는 UI
    public Text player2Hp;                                  //player2 Hp 보여주는 UI

    Player mPlayer = new Player();                         //Player 클래스 생성 New <======
    Player mPlayer2 = new Player();
    void Start()
    {

        //    mPlayer.Attack();                                  //player 메소드 Attack 호출
        //    mPlayer.Damage(30);                                //Player 메소드 Damage 호출
        //    Debug.Log(mPlayer.GetHp());                        //Player 의 HP를 보여준다
        //}

        // Update is called once per frame
        void Update()
        {
            playerHp.text = "Player1 HP;" + mPlayer.GetHp().ToString();         //player의 Hp를 UI로 표시
            player2Hp.text = "Player2 HP;" + mPlayer2.GetHp().ToString();         //player2의 Hp를 UI로 표시


            if (Input.GetMouseButtonDown(0))                    //왼쪽 마우스
            {
                mPlayer.Damage(1);                              //Player 메소드 Damage 호출
            }

            if (Input.GetMouseButtonDown(1))                     //오른쪽 마우스
            {
                mPlayer2.Damage(1);                              //Player2 메소드 Damage 호출
            }

        }
    }
