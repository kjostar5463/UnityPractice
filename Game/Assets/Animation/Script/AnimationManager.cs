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
        // 현재 애니메이터에 있는 애니매이션이 Close일 때
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            // 현재 애니매이션의 진행도가 >= 1 이면 애니메이터의 게임 오브젝트를 비활성화 한다
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
