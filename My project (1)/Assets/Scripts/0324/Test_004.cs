using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;
    public Text textUI;
    public Text hpTextUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (Input.GetMouseButtonDown(0))                //���ǹ����� ���콺 �Է� ���� 0 �μ��� ���� ���콺
        {
            hp += 10;
        }
        if (Input.GetMouseButtonDown(1))                //���ǹ����� ���콺 �Է� ���� 1�μ��� ������ ���콺
        {
            hp -= 10;
        }
        if (hp <= 50)                                  //50 �����϶�
        {
            Debug.Log("����!");
        }
        else if (hp >= 200)
        {
            
            textUI.text = "���� !";
        }
        else
        {
            textUI.text = "���!";
        }

        hpTextUI.text = "hp : " + hp.ToString();
    }
}
