using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Transform boxes;
    [SerializeField] Vector3[] winConditions;
    [SerializeField] Text winnerText;
    [SerializeField] GameObject winPanel;
    public Sprite[] sprites;
    public enum player
    {
        X,
        O,
        Empty
    }

    public player currentPlayer;
    public player winner;

    public bool checkBoard()
    {
        Vector3 winCondition;
        for (int w = 0; w < winConditions.Length; w++)
        {
            winCondition = winConditions[w];
            if (!(boxes.GetChild((int)winCondition.x).GetComponent<INPUT>().inp == player.Empty ||
                boxes.GetChild((int)winCondition.y).GetComponent<INPUT>().inp == player.Empty ||
                boxes.GetChild((int)winCondition.z).GetComponent<INPUT>().inp == player.Empty))
            {
                if (boxes.GetChild((int)winCondition.x).GetComponent<INPUT>().inp == boxes.GetChild((int)winCondition.y).GetComponent<INPUT>().inp &&
                    boxes.GetChild((int)winCondition.x).GetComponent<INPUT>().inp == boxes.GetChild((int)winCondition.z).GetComponent<INPUT>().inp)
                {
                    winner = boxes.GetChild((int)winCondition.x).GetComponent<INPUT>().inp;
                    openResultScreen("Winner is " + winner);
                    return true;
                }
            }
        }
        return false;
    }

    public void openResultScreen(string text)
    {
        winnerText.text = text;
        winPanel.SetActive(true);
    }

    public bool isDraw()
    {
        for (int c = 0; c < boxes.childCount; c++)
        {
            if (boxes.GetChild(c).GetComponent<INPUT>().inp == player.Empty)
            {
                return false;
            }
        }
        return true;
    }
}
