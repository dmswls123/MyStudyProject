using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCoin : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float PopPower = 2.5f;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); // ������Ʈ�� ã�Ƽ� Ÿ���� <Rigidbody2D>�� �༮�� rigid������ �Ҵ��Ѵ�.
        rigid.AddForce(Vector2.up * PopPower, ForceMode2D.Impulse); // Vector2.up ���� ���� ���Ѵ�.
        Invoke(nameof(DisableObject),1.5f); // Invoke : 1.5f �ڿ� DisableObject �Լ� ����
        Destroy(gameObject, 2f);            // gameObject �ı��Ѵ� 2f�ڿ�
    }

    private void DisableObject()
    {
        gameObject.SetActive(false); // ���� ������Ʈ�� ��Ȱ���ض�.
    }
}
