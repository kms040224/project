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
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);           //화면에서의 2차원 마우스 좌표를 입력해서 3d 카메라에서 hit로 만드는 함수

            RaycastHit hit;

            if(Physics.Raycast(cast, out hit))    //Rast 가 충돌 감지된것을 hit로 돌려준다.
            {
                if (hit.collider.tag == "Ground")
                {
                    GameObject temt = (GameObject)Instantiate(Monster);
                    temt.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);
                }

                Debug.Log(hit.collider.name);    //오브젝트 이름을 출력

                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);
            }

        }
    }
}
