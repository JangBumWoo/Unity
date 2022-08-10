using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRd;
    public float speed = 10.0f;
    Vector3 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>();
        ballRd.AddForce(-speed, 0, -speed * 0.7f); // 11�� ����

        startPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
            // ���� �±װ� WALL�� �浹�� ��� 
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos; // �Ի簢
                // incomvec: �Ի簢 = ���� ����ġ - ��ŸƮ����
            Vector3 normalVec = collision.contacts[0].normal; // �������� (��������)
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // �ݻ簢 

            reflectVec = reflectVec.normalized;  // �ݻ簢 ����ȭ
            ballRd.AddForce(reflectVec * speed);
        }

        if (collision.gameObject.CompareTag("BLOCK"))
        // ���� �±װ� WALL�� �浹�� ��� 
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos; // �Ի簢
                                                   // incomvec: �Ի簢 = ���� ����ġ - ��ŸƮ����
            Vector3 normalVec = collision.contacts[0].normal; // �������� (��������)
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // �ݻ簢 

            reflectVec = reflectVec.normalized;  // �ݻ簢 ����ȭ
            ballRd.AddForce(reflectVec * speed);
           
            // �浹�� �ش� ���� ����
            Destroy(collision.gameObject);
        
        }


        startPos = transform.position;

    }
}