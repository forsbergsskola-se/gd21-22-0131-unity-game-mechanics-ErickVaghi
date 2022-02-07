using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private Transform transformPlayer;
    void Update()
    {
        var directionToPlayer = transformPlayer.position - transform.position;
        directionToPlayer.Normalize();
        var horizontalDirection = directionToPlayer.x;
        commandContainer.walkCommand = horizontalDirection;
    }
}
