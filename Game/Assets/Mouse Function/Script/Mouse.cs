using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Mouse : MonoBehaviour
{
    bool power = false;
    private RaycastHit hit;

    [SerializeField] Rigidbody rigid;
    [SerializeField] GameObject state;
    [SerializeField] VideoPlayer video;
    [SerializeField] LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                power = !power;

                if(power == true)
                    video.Play();
                else
                    video.Stop();
            }
        }
    }

    private void OnMouseDown()
    {
        state.SetActive(true);
        rigid.isKinematic = true;
    }

    private void OnMouseDrag() 
    {
        //���콺�� ��ġ�� �����մϴ�.
        Vector3 mousePosition = new Vector3
            (
                Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.WorldToScreenPoint(gameObject.transform.position).z
            );

        //���콺 ��ǥ�� ScreenToWorldPoint�� �����Ͽ� ������Ʈ�� ��ġ�� �����մϴ�.
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objectPosition;
    }

    private void OnMouseUp()
    {
        state.SetActive(false);
        rigid.isKinematic = false;
    }
}
