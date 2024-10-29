using UnityEngine;

public class TileColorChanger : MonoBehaviour
{
    public Color accentColor = Color.red; // Настраиваемый акцентный цвет
    public Color defaultColor = Color.white; // Настраиваемый дефолтный цвет
    public Collider2D groundCollider; // Привяжите сюда основной BoxCollider2D персонажа
    public LevelManager levelManager; // Привяжите сюда LevelManager

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
