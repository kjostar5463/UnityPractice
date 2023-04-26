using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatoinRetargeting : MonoBehaviour
{
    private int count;
    private float speed = 10;

    [SerializeField] Dropdown dropDown;
    [SerializeField] Animator[] animator;

    public void SpeedSettting()
    {
        if (speed++ >= 10)
            speed = 1;
        for(int i = 0; i < animator.Length; i++)
        {
            animator[i].speed = speed / 10;
        }
    }

    public void LayerMaskSetting(int layerIndex)
    {
        count = count % 2;

        switch(count++)
        {
            case 0:Camera.main.cullingMask = ~(1 << layerIndex); 
                break;
            case 1:Camera.main.cullingMask = -1;
                break;
        }
    }

    public void CullingModeSetting()
    {
        int index = dropDown.value;

        for(int i = 0; i < animator.Length; i++) 
        {
            animator[i].cullingMode = (AnimatorCullingMode)index;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
