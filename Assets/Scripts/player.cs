using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 3.5f;
    float diagonalSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        diagonalSpeed = Mathf.Sqrt(speed * speed *2)/2;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(
            "W: " + Input.GetKey("w")+
            " A: " + Input.GetKey("a")+
            " S: " + Input.GetKey("s")+
            " D: " + Input.GetKey("d")+
            "grav: " + Physics.gravity);
        if(Input.GetKey("w")){
            if(Input.GetKey("a")||Input.GetKey("d")){
            transform.position += Vector3.up *diagonalSpeed * Time.deltaTime;
            }
            else{
                transform.position += Vector3.up *speed * Time.deltaTime;
            }
        }
        if(Input.GetKey("a")){
            if(Input.GetKey("w")||Input.GetKey("s")){
                transform.position += Vector3.left *diagonalSpeed * Time.deltaTime;
            }
            else{
                transform.position += Vector3.left *speed * Time.deltaTime;
            }
        }
        if(Input.GetKey("s")){
            if(Input.GetKey("a")||Input.GetKey("d")){
                transform.position += Vector3.down *diagonalSpeed * Time.deltaTime;
            }
            else{
                transform.position += Vector3.down *speed * Time.deltaTime;
            }            
        }
        if(Input.GetKey("d")){
            if(Input.GetKey("w")||Input.GetKey("s")){
                transform.position += Vector3.right *diagonalSpeed * Time.deltaTime;
            }
            else{
                transform.position += Vector3.right *speed * Time.deltaTime;
            }            
        }
        

    }
}
