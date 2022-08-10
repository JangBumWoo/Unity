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
        ballRd.AddForce(-speed, 0, -speed * 0.7f); // 11시 방향

        startPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
            // 공이 태그값 WALL과 충돌할 경우 
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos; // 입사각
                // incomvec: 입사각 = 공의 현위치 - 스타트포스
            Vector3 normalVec = collision.contacts[0].normal; // 법선벡터 (수직벡터)
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // 반사각 

            reflectVec = reflectVec.normalized;  // 반사각 정규화
            ballRd.AddForce(reflectVec * speed);
        }

        if (collision.gameObject.CompareTag("BLOCK"))
        // 공이 태그값 WALL과 충돌할 경우 
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos; // 입사각
                                                   // incomvec: 입사각 = 공의 현위치 - 스타트포스
            Vector3 normalVec = collision.contacts[0].normal; // 법선벡터 (수직벡터)
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // 반사각 

            reflectVec = reflectVec.normalized;  // 반사각 정규화
            ballRd.AddForce(reflectVec * speed);
           
            // 충돌된 해당 블럭 제거
            Destroy(collision.gameObject);
        
        }


        startPos = transform.position;

    }
}
