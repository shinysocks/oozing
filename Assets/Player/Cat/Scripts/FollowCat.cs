using UnityEngine;

public class FollowCat : MonoBehaviour
{
    public Transform target;

    private void FixedUpdate()
    {
        transform.position = target.position;
    }
}