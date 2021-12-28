using UnityEngine;

public class Box : MonoBehaviour
{
    GameController gameController;
    [SerializeField] SpriteRenderer input;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void OnMouseDown()
    {
        if (input.sprite == null && gameController.winner == GameController.player.Empty)
        {
            input.sprite = gameController.sprites[(int)gameController.currentPlayer];
            GetComponent<INPUT>().inp = gameController.currentPlayer;
            if (!gameController.checkBoard() && gameController.isDraw())
            {
                gameController.openResultScreen("It's Draw");
            }
            gameController.currentPlayer = (gameController.currentPlayer == GameController.player.X) ? (GameController.player.O ) : (GameController.player.X);
        }
    }

}
