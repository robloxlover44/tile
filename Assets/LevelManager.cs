using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI congratsText; // ��������� ���� ��������� ������ ��� ������������
    private int totalTiles; // ����� ���������� ������
    private int coloredTiles; // ���������� ���������� ������

    void Start()
    {
        totalTiles = FindObjectsOfType<TileColorChanger>().Length;
        congratsText.gameObject.SetActive(false); // ������ ����� ��� ������
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
    