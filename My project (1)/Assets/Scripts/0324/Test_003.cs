using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test_003 : MonoBehaviour
{
    int herbNum = 1;                   //���� herbNum ���� �Ŀ� 1�� �Է�
    void Start()
    {
        

        if(herbNum==1)                     //���ǽ� herbNum�� 1�� ��� �ȿ� ������ �����Ѵ�
        {
            Debug.Log("ü���� 50 ȸ��");   //console.Log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�
        }
        else
        {
            Debug.Log("ü�� -50");         //Console.Log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�
        }
    }

   
}
