using UnityEngine;

public class INPUT : MonoBehaviour
{
    GameController gameController;
    public GameController.player inp;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

}
