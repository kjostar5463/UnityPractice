using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AnimationClip [] animationClip;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < animationClip.Length; i++)
        {
            var data = AnimationUtility.GetAnimationClipSettings(animationClip[i]);

            data.loopTime = false;

            AnimationUtility.SetAnimationClipSettings(animationClip[i], data);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �ִϸ����Ϳ� �ִ� �ִϸ��̼��� Close�� ��
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            // ���� �ִϸ��̼��� ���൵�� >= 1 �̸� �ִϸ������� ���� ������Ʈ�� ��Ȱ��ȭ �Ѵ�
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
            {
                animator.gameObject.SetActive(false);
            }
        }
    }
    
    public void Open()
    {
        animator.gameObject.SetActive(true);
    }
    public void Close()
    {
        animator.SetTrigger("Close");
    }
}
