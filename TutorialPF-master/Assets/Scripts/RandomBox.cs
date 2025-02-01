using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBox : MonoBehaviour
{
    public GameObject CoinPrefab; // ���� �������� ����ϰڴ�.
    public bool isActivate = true; // RandomBox�� Ȱ��ȭ �Ǿ� �ִ� ���´�.
    SpriteRenderer _sr;
    public Sprite unActivateBoxSprite;

    private void Start()
    {
        _sr = GetComponentInParent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isActivate) // isActivate������ true�� ���� �Ʒ��ڵ带 �����մϴ�.
        {
            // ���������� Ŭ�����߽��ϴ�.
            Debug.Log("���� �ڽ��� �����߽��ϴ�.");
            isActivate = false; // isActivate�� false�� �ٲ��
            Instantiate(CoinPrefab, transform.position, Quaternion.identity);

            // �θ���(������Ʈ�̸��� RandomBox����) SpriteRenderer����� sprite ���� tilemap_29�� �����϶�.
            _sr.sprite = unActivateBoxSprite;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("���� �ڽ��� �浹�� �������ϴ�.");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("���� �ڽ��� �浹 ���� ���Դϴ�.");
    }
}
