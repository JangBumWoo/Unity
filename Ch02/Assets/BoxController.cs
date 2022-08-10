using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision) // 충돌
    {
        print("충돌 Enter: " + collision.gameObject.name);
        // 게임 오브젝트와 충돌할 때
    }

    private void OnCollisionExit(Collision collision)
    {
        print("충돌 Exit: " + collision.gameObject.name);
    }
}
