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

    public void OnCollisionEnter(Collision collision) // �浹
    {
        print("�浹 Enter: " + collision.gameObject.name);
        // ���� ������Ʈ�� �浹�� ��
    }

    private void OnCollisionExit(Collision collision)
    {
        print("�浹 Exit: " + collision.gameObject.name);
    }
}