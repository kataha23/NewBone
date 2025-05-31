using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveInput : MonoBehaviour
{
    // 이 아래에 작성한 코드는 데이터에 해당하는 부분입니다.
    public float moveSpeed = 5f;
    public Rigidbody2D rigid;

    // Update의 영역 안에 코드를 작성하면 게임이 실행되는 도중에 코드가 작동합니다.
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector2 (h * moveSpeed, 0);
    }
}
