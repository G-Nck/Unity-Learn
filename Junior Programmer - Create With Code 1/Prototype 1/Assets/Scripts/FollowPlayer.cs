using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // �� ������Ʈ ��ġ�� �÷��̾� ��ġ���� 7m �� 5m ���� �����մϴ�.
        transform.position = player.transform.position + offset;
    }
}
