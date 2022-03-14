using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//подключил определение маршрута 

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float dist;
    NavMeshAgent nav;
    public float Radius = 15;
    public bool OnEnemy = false;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>(); 
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //расчет дистанции от игрока до enemy
        dist = Vector3.Distance(player.transform.position, transform.position);
        if(OnEnemy == true)
        {
         if(dist > Radius)
        {
            nav.enabled = false;
            anim.SetBool("idle", true);
            anim.SetBool("run", false);
               anim.SetBool("idleidle",false);
        }
        if(dist < Radius)
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
            anim.SetBool("run", true);
             anim.SetBool("idle", false);
             anim.SetBool("idleidle",false);
        }
        }
         else if (OnEnemy == false)
        {
              nav.enabled = false;
               anim.SetBool("idleidle",true);
              anim.SetBool("run", false);
             anim.SetBool("idle", false);
            
        }
       
       
    }
    
}
