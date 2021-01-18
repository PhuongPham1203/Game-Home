using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoAttack1(){
        Vector3 pos = this.transform.position;
        if(this.transform.localScale.x>0){
            pos.x += 1;
        }else{
            pos.x -= 1;
        }
        Instantiate(this.attack1,pos,Quaternion.identity);
        
    }

    public void DoAttack2(){

        Vector3 pos = this.transform.position;
        if(this.transform.localScale.x>0){
            pos.x += 1;
        }else{
            pos.x -= 1;
        }
        Instantiate(this.attack2,pos,Quaternion.identity);
    }

    public void DoAttack3(){
        Vector3 pos = this.transform.position;
        if(this.transform.localScale.x>0){
            pos.x += 1;
        }else{
            pos.x -= 1;
        }
        Instantiate(this.attack3,pos,Quaternion.identity);
    }
}
