

  using UnityEngine;

public class SimpleCameraFollow : MonoBehaviour
{
    public Transform player;  // The player's transform
    public Vector3 offset;  

    void Update()
    {
     
        transform.position = player.position + offset;
    }
}