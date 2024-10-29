using UnityEngine;

public class TileColorChanger : MonoBehaviour
{
    public Color accentColor = Color.red; // ������������� ��������� ����
    public Color defaultColor = Color.white; // ������������� ��������� ����
    public Collider2D groundCollider; // ��������� ���� �������� BoxCollider2D ���������
    public LevelManager levelManager; // ��������� ���� LevelManager

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != groundCollider)
        {
            SpriteRenderer spriteRenderer = other.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                if (spriteRenderer.color == defaultColor)
                {
                    spriteRenderer.color = accentColor;
                    levelManager.TileColored();
                }
                else
                {
                    spriteRenderer.color = defaultColor;
                    levelManager.TileUncolored();
                }
            }
        }
    }
}
