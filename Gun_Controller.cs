using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{   
    public float time = 0.0f;
    public float interpolationPeriod =1.0f;
    public GameObject red_ball;
    public GameObject green_ball;
    public GameObject blue_ball;
    private List<GameObject> bullets=new List<GameObject>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            this.Shoot_red_ball();
        else if (Input.GetMouseButtonDown(1))
            this.Shoot_green_ball();
        else if (Input.GetMouseButtonDown(2))
            this.Shoot_blue_ball();
        this.time += Time.deltaTime;
        if (this.time >= this.interpolationPeriod){
            this.time = 0.0f;
            for (int i =0; i< bullets.Count;i++){
                if(bullets[i].transform.position.y < -5){
                    bullets.RemoveAt(i);
                }
            }
        }
    }
    void Shoot_red_ball()
    {
        GameObject bullet = Instantiate(red_ball,this.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward*1000);
        this.bullets.Add(bullet);
    }
    void Shoot_blue_ball()
    {
        GameObject bullet = Instantiate(blue_ball,this.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward*1000);
        this.bullets.Add(bullet);
    }
    void Shoot_green_ball()
    {
        GameObject bullet = Instantiate(green_ball,this.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward*1000);
        this.bullets.Add(bullet);
    }
}
