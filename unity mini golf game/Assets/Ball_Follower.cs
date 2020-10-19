using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Follower : MonoBehaviour
{
    Transform Balltr;
    // Start is called before the first frame update
    void Start()
    {
        Balltr = GameObject.FindGameObjectWithTag("Player").transform;
        setCameraPos();
    }
    void setCameraPos(){
        transform.position= new Vector3(Balltr.position.x,3,Balltr.position.z-2);
    }
    // Update is called once per frame
    void Update()
    {
        setCameraPos();
    }
}
