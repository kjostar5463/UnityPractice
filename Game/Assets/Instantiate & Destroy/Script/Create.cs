using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public Button button;
    public GameObject prefab;

    private bool active = true;
    private float fixedTime = 5f;
    private float currentTime = 5f;

    public void GenericCreate()
    {
        active = false;

        // Instantiate : ���� ������Ʈ�� �����ϴ� �Լ�
        Instantiate
        (
            prefab,                     // �����Ǵ� ���� ������Ʈ
            new Vector3(0, -1.25f, 0),  // �����Ǵ� ��ġ ��
            prefab.transform.rotation   // �����Ǵ� ȸ�� ��
        ).AddComponent<Delete>();       
    }

    // Update is called once per frame
    void Update()
    {
        if(active == false)
        {
            button.interactable = false;
            currentTime -= Time.deltaTime;
            button.image.fillAmount = currentTime / fixedTime;

            if (currentTime <= 0)
            {
                active = true;
                button.interactable = true;
                button.image.fillAmount = currentTime = fixedTime;
            }
        }
    }
}
