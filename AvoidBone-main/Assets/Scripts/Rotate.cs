using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // �� �Ʒ��� �ۼ��� �ڵ�� �����Ϳ� �ش��ϴ� �κ��Դϴ�.
    public float rotateSpeed = 10;
    public Rigidbody2D rigid;

    // Update�� ���� �ȿ� �ڵ带 �ۼ��ϸ� ������ ����Ǵ� ���߿� �ڵ尡 �۵��մϴ�.
    void FixedUpdate()
    {
        rigid.AddTorque(rotateSpeed);
    }
}
