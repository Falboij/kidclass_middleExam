
using UnityEngine;

public class Mid : MonoBehaviour
{
    // �D���W�r
    [Tooltip("���a���W")]
    public string Name = "�_�I�a";
    // �D����q
    [Tooltip("�D����q")]
    public int hp = 100;
    // ���ʳt��
    [Tooltip("���ʳt��")]
    [Range(1, 10)]
    public float speed = 2.5f;
    // �D������
    public KeyCode KeyCodeJump = KeyCode.Space;
    public KeyCode KeyCodeuUpArrow = KeyCode.UpArrow;
    public KeyCode KeyCodeuDownArrow = KeyCode.DownArrow;
    public KeyCode KeyCodeuRightArrow = KeyCode.RightArrow;
    public KeyCode KeyCodeuLeftArrow = KeyCode.LeftArrow;
    // �D���_�l��m
    public Vector2 character;
}
