using System.Collections.Specialized;
using System.Runtime;
using UnityEngine;

public class EnemyWaypoints : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 2f;
    private int waypointIndex = 0;
    public float distance;
    public Transform Player;
    Transform target;
    Vector2 moveDirection;

    private void Start()
    {

        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            if (waypointIndex == waypoints.Length)
                waypointIndex = 0;
        }
    }
    
}
