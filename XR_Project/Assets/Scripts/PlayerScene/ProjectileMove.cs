using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public enum PROJECTILETYPE                      //enum���� Ÿ�� ����
    {
        PLAYER,
        MONSTER
    }
    
    public Vector3 launchDirection;                             //�߻����

    public PROJECTILETYPE projectileType;
    
    private void FixedUpdate()
    {
        float moveAmount = 10 * Time.fixedDeltaTime;             //�̵� �ӵ� ����
        transform.Translate(launchDirection* moveAmount);          //Translate�� �̵�
    }

    //private void OnCollisionEnter(Collision collision)          //�浹�� �Ͼ�� ���
    //{
    //    Debug.Log(collision.gameObject);
    //    if (collision.gameObject.tag == "Object")               //tag���� ������Ʈ�� ���
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    if(collision.gameObject.tag == "Monster")
    //    {
    //        Destroy(this.gameObject);
    //        collision.gameObject.GetComponent<Monster>().Damaged(1);
    //    }
    //}

    private void OnTriggerEnter(Collider other) //Ʈ���� ���� �Լ�
    {
        if (other.CompareTag("Monster")&& projectileType == PROJECTILETYPE.PLAYER)  //tag�� �˻��Ѵ�
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<Monster>().Damaged(1);
        }

        if (other.CompareTag("Monster") && projectileType == PROJECTILETYPE.MONSTER)    //tag�� �˻��Ѵ�
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<PlayerHp>().Damaged(1);
        }
    }
}
