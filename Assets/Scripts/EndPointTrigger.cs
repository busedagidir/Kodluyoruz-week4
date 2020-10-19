using UnityEngine;

public class EndPointTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}
