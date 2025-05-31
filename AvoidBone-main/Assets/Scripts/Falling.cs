using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    // �� �Ʒ��� �ۼ��� �ڵ�� �����Ϳ� �ش��ϴ� �κ��Դϴ�.
    public float fallingSpeed = 5f;
    public Rigidbody2D rigid;

    // Update�� ���� �ȿ� �ڵ带 �ۼ��ϸ� ������ ����Ǵ� ���߿� �ڵ尡 �۵��մϴ�.
    void Update()
    {
        rigid.velocity = Vector2.down * fallingSpeed;   
    }
}
