using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Monster;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);           //ȭ�鿡���� 2���� ���콺 ��ǥ�� �Է��ؼ� 3d ī�޶󿡼� hit�� ����� �Լ�

            RaycastHit hit;

            if(Physics.Raycast(cast, out hit))    //Rast �� �浹 �����Ȱ��� hit�� �����ش�.
            {
                if (hit.collider.tag == "Ground")
                {
                    GameObject temt = (GameObject)Instantiate(Monster);
                    temt.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);
                }

                Debug.Log(hit.collider.name);    //������Ʈ �̸��� ���

                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);
            }

        }
    }
}