using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;                             //발사방향

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;             //이동 속도 설정
        transform.Translate(launchDirection* moveAmount);          //Translate로 이동
    }

    private void OnCollisionEnter(Collision collision)          //충돌이 일어났을 경우
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "Object")               //tag값이 오브젝트인 경우
        {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "Monster")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<Monster>().Damaged(1);
        }
    }
}
