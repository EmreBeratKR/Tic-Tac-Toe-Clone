using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] GameObject boxPrefab;


    void Start()
    {
        spawn(3, 3, 3);
    }

    void spawn(int lenX, int lenY, int edge)
    {
        for (int y = 0; y < lenY; y++)
        {
            for (int x = 0; x < lenX; x++)
            {
                Instantiate(boxPrefab, new Vector3(x, y) * edge, Quaternion.identity, transform);
            }
        }
    }
}
