using UnityEngine;

public class ProjectileDistance : MonoBehaviour
{
    public Transform player;
    public Transform point;

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(player.position, point.position);
    }
}
