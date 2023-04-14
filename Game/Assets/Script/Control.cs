using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Control : MonoBehaviour
{
    // ��ũ��Ʈ�� ��Ȱ��ȭ�� ���·� ���� ������Ʈ�� �����Ǿ��� �� �� �� ���� ȣ���ϴ� �̺�Ʈ �Լ� 
    private void Awake()
    {
        Debug.Log("Awake");
    }
    // ��ũ��Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Start is called before the first frame update
    // ��ũ��Ʈ�� Ȱ��ȭ�� ���·� ���� ������Ʈ�� �����Ǿ��ٸ� �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ� 
    void Start()
    {
        Debug.Log("Start");
    }
    // �����Ӱ� ������� ������ �ð� ����(TimeStep 0.02��)���� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    // Update is called once per frame
    // ���� ������Ʈ�� Ȱ��ȭ�� ���·� �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�
    void Update()
    {
        // GetKey : Ű�� ������ ���� �� ȣ��Ǵ� �Լ�
        // GetKeyDown : Ű�� ������ ��
        // GetKeyUp : Ű�� ������ ���� ��
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.position = transform.position + Vector3.forward * 10f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Vector3.back * 10f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Vector3.left * 10f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right * 10f * Time.deltaTime;
        }

        Debug.Log("Update");
    }

    // ���� ������Ʈ�� Ȱ��ȭ�� ���·� Update�Լ��� ȣ��ǰ� ���� �������� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    // ������ ���� �Ǿ��� �� �� ���� ȣ��Ǵ� �Լ�
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }
    // ������ ��Ȱ��ȭ�ǰų� ��Ȱ�� ������ �� �� �Լ��� ȣ��
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    // ���� ������Ʈ�� Ȱ��ȭ�� ���·� �ı��Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
