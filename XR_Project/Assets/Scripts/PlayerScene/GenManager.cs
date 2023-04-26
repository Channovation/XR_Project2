using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenManager : MonoBehaviour
{

    public GameObject Monster;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition); // 2d ȭ�鿡�� ����Ƽ�� 3d ȭ������ ��ȯ�ϴ� �Լ� ray�� ����

            RaycastHit hit;
            if(Physics.Raycast(cast,out hit))  //Ray�� ������ ���� ����� �Ͼ��
            {
                if (hit.collider.tag == "Ground")
                {
                    GameObject temp = (GameObject)Instantiate(Monster);                     //������ ���� �Լ�(���͸� ����)
                    temp.transform.position = hit.point + new Vector3(0.0f, 0.1f, 0.0f); //������ ���͸� ground���� ��¦ ���� ��Ŵ
                    //cast.origin => Ray�� �� ������, hit.point�� Ray�� ���� ��ǥ
                    Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);


                }

            }
        }
    }
}