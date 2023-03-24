using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for int( i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);
        //}
        //for int(i = 0; i < 10; i+=2)
        //{
        //    Debug.Log(i);
        //}

        //for int(i = 3; i > 0; i--) ;
        //{
        //    Debug.Log(i);
        //}
        for (int i = 0; i < 10; i++)                      //0부터 \9까지 합값 출력
        {
            if (i % 2 == 0) 
            {
                Debug.Log(i);
            }
        }
        Debug.Log("===================================================================");

        int sum = 0;
        for(int i = 0; i < 10; i++)
        {                                                    //0부터 9까지 합값 출력
            sum = +i;
        }
        Debug.Log(sum);

        Debug.Log("===================구구단=====================");

        for (int i  = 0; i < 10; i++)   //i가 1부터 10까지
        {
            for(int j = 1; j<10; j++)   //i가 1부터 10까지
            {
                Debug.Log(i.ToString() + "X" + j.ToString() + "=" + (i * j).ToString());
            }
        }
    }

    //주석 단축키는 Ctrl + K + C , 주석 풀기는 Ctrl + K + U

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
