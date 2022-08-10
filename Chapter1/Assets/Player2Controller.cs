using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private Rigidbody playerRd;
    float speed = 10.0f;


    // ������ ó�� ����� ��
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // ������ ����� �� �� �����Ӻ��� ȣ�� 
    void Update()
    {
       // print("Update!");

        if(Input.GetKey(KeyCode.D) == true)
        {
            // Vector3 Ÿ���� ������ ����� �ӵ��� ������ ������Ʈ�� �̵��� �� �ִ�.
            // deltaTime�� ��ǻ���� ���ɿ� ���� ������ �ӵ��� �����ϵ��� ������ �ð� ������ ����ȭ��Ű�� ��  
            //transform.Translate(Vector3.right * speed * Time.deltaTime);
            playerRd.AddForce(speed, 0f, 0f); // (x,y,z)  
        
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            // transform.Translate(Vector3.left * speed * Time.deltaTime);
            playerRd.AddForce(-speed, 0f, 0f);
            // Addforce�� ���ӵ��� �ǹ� ���� �ش�
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            playerRd.AddForce(0f, 0f, speed);
        }  
      
        if (Input.GetKey(KeyCode.S) == true)
        {
            //transform.Translate(Vector3.back * speed * Time.deltaTime);
            playerRd.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.Space)== true)
        {
            playerRd.AddForce(0f, speed, 0f);
       
        }
    }
}
