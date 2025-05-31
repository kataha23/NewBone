using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveInput : MonoBehaviour
{
    // �� �Ʒ��� �ۼ��� �ڵ�� �����Ϳ� �ش��ϴ� �κ��Դϴ�.
    public float moveSpeed = 5f;
    public Rigidbody2D rigid;

    // Update�� ���� �ȿ� �ڵ带 �ۼ��ϸ� ������ ����Ǵ� ���߿� �ڵ尡 �۵��մϴ�.
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector2 (h * moveSpeed, 0);
    }
}
