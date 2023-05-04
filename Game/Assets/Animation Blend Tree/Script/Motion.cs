using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal"); // -1 ~ 1

        // SetFloat("�ִϸ����� �Ķ���� �̸�", �Ӽ� ��);
        // vertical ���� 0.1 ���� ũ��
        // vertical ���� -0.1 ���� �۴�
        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Horizontal", horizontal);
    }
}
