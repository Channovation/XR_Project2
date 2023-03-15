using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test2 : MonoBehaviour
{

    public int hp = 180;
    public Text textHpUI; //Hp UI ǥ�� ����
    public Text textStateUI; //state ǥ�� ����

    // Start is called before the first frame update
    void Start()
    {
        if( hp <= 50)
        {
            Debug.Log("����!");
        }
        else if(hp >= 200)
        {
            Debug.Log("���� !");
        }
        else
        {
            Debug.Log("��� !");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //-----------------------------------------------------------
        //UI ����
        //-----------------------------------------------------------
        textHpUI.text = hp.ToString(); // hp ���ڿ��� ����


        if (Input.GetMouseButtonDown(0)) //���콺 ���� ��ư
        {
            hp += 10;
        }
        if(Input.GetMouseButtonDown(1)) //���콺 ������ ��ư
        {
            hp -= 10;
        }

        if (hp <= 50)
        {
            textStateUI.text = "Run";
        }
        else if (hp >= 200)
        {
            textStateUI.text = "Attack!";
        }
        else
        {
            textStateUI.text = "Defance";
        }

        
    }
}


