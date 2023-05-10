using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{

    [SerializeField] protected SoundProfileData soundProfileData;

    public Vector3 launchDirection;
    public GameObject projectile;
    protected AudioManager AudioManager => AudioManager.Instance;


    // Start is called before the first frame update
    public void FireProjectile()
    {
        AudioManager.PlayOneShot(soundProfileData.GetRandomClip());
        GameObject temp = (GameObject)Instantiate(projectile);

        temp.transform.position = this.gameObject.transform.position;
        temp.transform.localScale = Vector3.one * 0.3f;
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;
        temp.GetComponent<ProjectileMove>().projectileType = ProjectileMove.PROJECTILETYPE.PLAYER;

        Destroy(temp, 10.0f);
    }
}
