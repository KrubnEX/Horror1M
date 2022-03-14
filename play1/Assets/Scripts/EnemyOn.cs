using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOn : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
