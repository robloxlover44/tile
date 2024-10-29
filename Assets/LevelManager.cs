using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI congratsText; // Привяжите сюда текстовый объект для поздравлений
    private int totalTiles; // Общее количество тайлов
    private int coloredTiles; // Количество окрашенных тайлов

    void Start()
    {
        totalTiles = FindObjectsOfType<TileColorChanger>().Length;
        congratsText.gameObject.SetActive(false); // Скрыть текст при старте
    }

    public void TileColored()
    {
        coloredTiles++;
        CheckCompletion();
    }

    public void TileUncolored()
    {
        coloredTiles--;
    }

    private void CheckCompletion()
    {
        if (coloredTiles == totalTiles)
        {
            congratsText.gameObject.SetActive(true);
        }
    }
}
    