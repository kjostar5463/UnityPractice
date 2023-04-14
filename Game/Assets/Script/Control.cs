using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Control : MonoBehaviour
{
    // 스크립트가 비활성화된 상태로 게임 오브젝트가 생성되었을 때 단 한 번만 호출하는 이벤트 함수 
    private void Awake()
    {
        Debug.Log("Awake");
    }
    // 스크립트가 활성화되었을 때 호출되는 이벤트 함수
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Start is called before the first frame update
    // 스크립트가 활성화된 상태로 게임 오브젝트가 생성되었다면 단 한 번만 호출되는 이벤트 함수 
    void Start()
    {
        Debug.Log("Start");
    }
    // 프레임과 상관없이 무조건 시간 기준(TimeStep 0.02초)으로 호출되는 이벤트 함수
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    // Update is called once per frame
    // 게임 오브젝트가 활성화된 상태로 매 프레임마다 호출되는 이벤트 함수
    void Update()
    {
        // GetKey : 키를 누르고 있을 때 호출되는 함수
        // GetKeyDown : 키를 눌렀을 때
        // GetKeyUp : 키를 누르고 뗐을 때
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

    // 게임 오브젝트가 활성화된 상태로 Update함수가 호출되고 나서 마지막에 호출되는 이벤트 함수
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    // 게임이 종료 되었을 때 한 번만 호출되는 함수
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }
    // 동작이 비활성화되거나 비활성 상태일 때 이 함수가 호출
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    // 게임 오브젝트가 활성화된 상태로 파괴되었을 때 호출되는 이벤트 함수
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
