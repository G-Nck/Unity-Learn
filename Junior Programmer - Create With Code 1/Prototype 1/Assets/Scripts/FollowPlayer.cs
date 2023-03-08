using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 이 오브젝트 위치를 플레이어 위치에서 7m 뒤 5m 위로 조정합니다.
        transform.position = player.transform.position + new Vector3(0, 5, -7);
    }
}
